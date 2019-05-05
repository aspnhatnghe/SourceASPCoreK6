using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace D01_Intro.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DemoController : Controller
    {
        public IActionResult OOP()
        {
            //tạo đối tượng
            HinhChuNhat hcn = new HinhChuNhat()
            {
                Dai = 4,
                Rong = 2.2
            };

            return Json(hcn);
        }

        public IActionResult Mang()
        {
            return View();
        }

        public IActionResult XuLyHinhTron(int? BanKinh)
        {
            //dấu chấm hỏi ở parameter cho phép null (trừ kiểu string)
            if (BanKinh.HasValue)
            {
                //Dùng ViewBag để gửi giá trị từ Action qua View
                ViewBag.ChuVi = Math.Round(2 * BanKinh.Value * Math.PI, 2);
                ViewBag.DienTich = Math.Pow(BanKinh.Value, 2) * Math.PI;
                ViewBag.BanKinh = BanKinh;
            }

            return View();
        }

        public IActionResult MyForm()
        {
            return View();
        }

        public int SoNguyen()
        {
            return 2;
        }

        public int Tong(int a, int b)
        {
            return a + b;
        }

        //Ghi chú 1 dòng
        /*
         * Nhiều dòng
         */
        double luongCoBan = 1490;

        /// <summary>
        /// Hàm xuất hiện câu chào
        /// </summary>
        /// <param name="hoTen">tên</param>
        /// <returns>câu chào</returns>
        public string Chao(string hoTen = "")
        {
            return $"Xin chào {hoTen}";
        }
    }
}