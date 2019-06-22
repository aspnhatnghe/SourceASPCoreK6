using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using D13_ADONET.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace D13_ADONET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ReadConfig()
        {
            var builder = new ConfigurationBuilder()
                //chỉ định thư mục chứa file json
                .SetBasePath(Directory.GetCurrentDirectory())
                //nếu đặt ở --> Config/xyz.json
                //.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Config"))
                //chỉ định tên file json
                .AddJsonFile("myappsettings.json");
            var config = builder.Build();
            //Lấy giá trị và gửi qua view dạng ViewBag
            ViewBag.Message = config["Message"];
            ViewBag.Config1 = config["MyConfig:Config1"];
            ViewBag.Name = config["MyConfig:Data:Name"];
            ViewBag.MyeStore = config.GetConnectionString("MyeStore");
            ViewBag.Database2 = config["ConnectionStrings:Database2"];
            var myconfig = config.GetSection("MyConfig");
            var c1 = myconfig["Config1"];
            var data = myconfig.GetSection("Data");
            return View();
        }
    }
}
