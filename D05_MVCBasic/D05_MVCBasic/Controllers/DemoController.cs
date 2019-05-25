using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace D05_MVCBasic.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ten = "Index";
            return View();
        }

        [Route("A")] //host/A
        [Route("A/B")] //host/A/B
        [Route("/C")] //host/C
        //[Route("/")] //host/    : dấu / tương host
        [Route("")] //host/Demo : bỏ action
        public IActionResult Test1()
        {
            ViewBag.Ten = "Test";
            //gửi tới view Index để hiển thị
            return View("Index");
        }

        [Route("dien-thoai/{chuoi}")]
        public IActionResult Test2(string chuoi)
        {
            ViewBag.Ten = chuoi;
            return View("Index");
        }

        //[Route("{loai}/{chuoi}")]
        public IActionResult Test3(string loai, string chuoi)
        {
            ViewBag.Ten = $"{loai} --> {chuoi}";
            return View("Index");
        }
    }
}