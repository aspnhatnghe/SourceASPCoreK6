using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShopK6.Models;

namespace MyShopK6.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly MyDbContext _content;
        private readonly IMapper _mapper;

        public KhachHangController(MyDbContext db, IMapper mapper)
        {
            _content = db; _mapper = mapper;
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

                _content.Add(khachHang);
                _content.SaveChanges();

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
            KhachHang khachHang = _content.KhachHangs.SingleOrDefault(p =>
            p.Email == model.Email &&
            ((model.MatKhau + p.RandomKey).ToMD5() == p.MatKhau));

            if (khachHang == null)//chưa có ==> ko thành công
            {
                ViewBag.ThongBaoLoi = "Sai thông tin đăng nhập";
                return View();
            }

            //ghi nhận đăng nhập thành công
            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name,khachHang.HoTen),
                new Claim(ClaimTypes.Email,khachHang.Email)
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
        public IActionResult Logout()
        {
            return View();
        }

        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }

        [Authorize]
        public IActionResult Purchase()
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
            var item = _content.KhachHangs.SingleOrDefault(p => p.Email == Email);
            if (item != null)
            {
                return Json(data: "Email này đã được đăng ký");
            }
            return Json(data: true);
        }
    }
}