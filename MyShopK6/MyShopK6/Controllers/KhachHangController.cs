using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyShopK6.Helper;
using MyShopK6.Models;

namespace MyShopK6.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public KhachHangController(MyDbContext db, IMapper mapper)
        {
            _context = db; _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(KhachHangView model)
        {
            if (ModelState.IsValid)
            {
                KhachHang khachHang = _mapper.Map<KhachHang>(model);

                khachHang.RandomKey = MyTool.GenerateRandomKey();
                khachHang.MatKhau = (model.MatKhau + khachHang.RandomKey).ToMD5();

                _context.Add(khachHang);
                _context.SaveChanges();

                return RedirectToAction("Login");
            }

            return View();
        }

        public IActionResult Login(string ReturnUrl = null)
        {
            ViewBag.ReturnUrl = ReturnUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string ReturnUrl = null)
        {
            KhachHang khachHang = _context.KhachHangs.SingleOrDefault(p =>
            p.Email == model.Email &&
            ((model.MatKhau + p.RandomKey).ToMD5() == p.MatKhau));

            if (khachHang == null)//chưa có ==> ko thành công
            {
                ViewBag.ThongBaoLoi = "Sai thông tin đăng nhập";
                return View();
            }

            HttpContext.Session.SetString("MaKh", khachHang.MaKh);

            //ghi nhận đăng nhập thành công
            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name,khachHang.HoTen),
                new Claim(ClaimTypes.Email,khachHang.Email),
                new Claim(ClaimTypes.Role, khachHang.Role)
            };
            // create identity
            ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");

            // create principal
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);

            //Lấy lại trang yêu cầu (nếu có)
            if (Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }

            return RedirectToAction("Profile", "KhachHang");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("MaKh");
            return RedirectToAction("Login", "KhachHang");
        }

        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }

        [Authorize(Roles = "Customer")]
        public IActionResult Purchase()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ClearOrder()
        {
            return Content("Role Admin");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [Authorize]
        public IActionResult Favourite()
        {
            return View();
        }

        public IActionResult CheckEmailAvaible(string Email)
        {
            var item = _context.KhachHangs.SingleOrDefault(p => p.Email == Email);
            if (item != null)
            {
                return Json(data: "Email này đã được đăng ký");
            }
            return Json(data: true);
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [Authorize]
        public IActionResult Checkout()
        {
            ViewBag.PhuongThucTt = new SelectList(_context.PhuongThucThanhToans.ToList(), "MaPt", "TenPt");
            
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(CheckoutModelView model)
        {
            List<CartItem> carts = Cart;

            //Lưu đơn hàng
            DonHang dh = new DonHang
            {
                NgayDat = DateTime.Now,
                MaKh = HttpContext.Session.GetString("MaKh"),
                TongTien = Cart.Sum(p => p.ThanhTien),
                NguoiNhan = model.NguoiNhan,
                DiaChiGiao = model.DiaChiGiao,
                MaPt = model.MaPt,
                MaTt = 1//mới đặt hàng
            };
            _context.Add(dh);
            _context.SaveChanges();

            //Lưu chi tiết đơn hàng
            foreach(var item in Cart)
            {
                ChiTietDonHang ctdh = new ChiTietDonHang
                {
                  MaDh = dh.MaDh, SoLuong = item.SoLuong,
                  DonGia = item.HangHoa.DonGia,
                  GiamGia = item.HangHoa.GiamGia
                };
                _context.Add(ctdh);
            }
            _context.SaveChanges();

            //Xóa đơn hàng ở session
            HttpContext.Session.Remove("GioHang");
            //Gửi mail thông báo
            return View();
        }

        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }

                return data;
            }
        }

    }
}