using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace D09_Validation_Layout.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //1. Sinh mã 5 kí tự
            Random rd = new Random();
            string pattern = "zaqwsxcderfvbgtyhnmjuik,!@#$%^&*()+=|";
            StringBuilder mann = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                mann.Append(pattern[rd.Next(0, pattern.Length)]);
            }

            //2. Dùng Session để lưu mã ngẫu nhiên
            HttpContext.Session.SetString("MaNgauNhien", mann.ToString());
            return View();
        }

        public string KiemTraBaoMat(string MaBaoMat)
        {
            string maBmServer = HttpContext.Session.GetString("MaNgauNhien");
            return maBmServer == MaBaoMat ? "true" : "false";
        }

        public IActionResult T1()
        {
            return View();
        }

        public IActionResult T2()
        {
            return View();
        }
        public IActionResult T3()
        {
            string[] danhMuc = { "Tivi", "Laptop", "Điện thoại", "Chuột", "Bàn phím" };

            return PartialView("_Category", danhMuc);
        }
    }
}