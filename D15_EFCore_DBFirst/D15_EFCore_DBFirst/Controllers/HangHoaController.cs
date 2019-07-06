using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D15_EFCore_DBFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace D15_EFCore_DBFirst.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly MyeStoreContext ctx;
        public HangHoaController(MyeStoreContext db)
        {
            ctx = db;
        }
        public IActionResult TimKiem(string TuKhoa = "", double GiaTu = 0, double GiaDen = 0)
        {
            //Lấy hàng hóa theo tiêu chí
            var dsHangHoa = ctx.HangHoa.AsQueryable();

            if(!string.IsNullOrEmpty(TuKhoa))
            {
                //dấu => : toán tử lambda
                dsHangHoa = dsHangHoa.Where(p => p.TenHh.Contains(TuKhoa)).AsQueryable();
            }

            if(GiaTu > 0)
            {
                dsHangHoa = dsHangHoa.Where(hh => hh.DonGia >= GiaTu).AsQueryable();
            }

            if (GiaDen > 0)
            {
                dsHangHoa = dsHangHoa.Where(hh => hh.DonGia <= GiaDen).AsQueryable();
            }

            //Khai báo lấy thêm thông tin loại
            dsHangHoa = dsHangHoa.Include(hh => hh.MaLoaiNavigation);
            return View(dsHangHoa);
        }

        public IActionResult DoanhSoTheoHangHoa()
        {
            //Thống kê doanh thu theo hàng hóa
            var data = ctx.ChiTietHd
                //gom nhóm theo hàng hóa
                .GroupBy(p => p.MaHhNavigation)
                //sau khi gom Key chính là HangHoa
                .Select(p=> new {
                    HangHoa = p.Key.TenHh,
                    SoLuong = p.Sum(q => q.SoLuong),
                    DoanhThu = p.Sum(q => q.SoLuong * q.DonGia)
                });
            return Json(data);
        }
        public IActionResult DoanhSoTheoLoai()
        {
            //Thống kê doanh thu theo loại
            var data = ctx.ChiTietHd
                //gom nhóm theo loại
                .GroupBy(p => p.MaHhNavigation.MaLoaiNavigation)
                //sau khi gom Key chính là Loai
                .Select(p => new {
                    Loai = p.Key.TenLoai,                    
                    DoanhThu = p.Sum(q => q.SoLuong * q.DonGia),
                    GiaTrungBinh = p.Sum(q => q.SoLuong * q.DonGia) / p.Sum(q => q.SoLuong),
                    GiaThapNhat = p.Min(q => q.DonGia)
                });
            return Json(data);
        }

        public IActionResult ThongKe()
        {
            var data = ctx.ChiTietHd
                //gom theo tháng/năm và tên loại
                .GroupBy( p=> new {
                    Thang = p.MaHdNavigation.NgayDat.Month,
                    Nam = p.MaHdNavigation.NgayDat.Year,
                    Loai = p.MaHhNavigation.MaLoaiNavigation.TenLoai
                })
                .Select(p => new {
                    p.Key.Loai,
                    NamThang = $"{p.Key.Thang}/{p.Key.Nam}",
                    DoanhThu = p.Sum(q => q.SoLuong * q.DonGia)
                })
                //sắp xếp tăng dần theo loại, giảm dần theo doanh thu
                .OrderBy(p => p.Loai)
                .ThenByDescending(p => p.DoanhThu)
                ;

            return Json(data);
        }

        const int SoHangHoaMoiTrang = 5;
        public IActionResult PhanTrang(int page = 1)
        {
            var dsHangHoa = ctx.HangHoa
                .Skip((page - 1) * SoHangHoaMoiTrang)
                .Take(SoHangHoaMoiTrang)
                .Select(p=> new HangHoaView {
                    MaHh = p.MaHh, TenHh = p.TenHh,
                    Loai = p.MaLoaiNavigation.TenLoai,
                    Hinh = p.Hinh,
                    GiaBan = p.DonGia.Value,
                    NgaySx = p.NgaySx,
                    SoLuong = new Random().Next()
                });

            return View(dsHangHoa);
        }
    }
}