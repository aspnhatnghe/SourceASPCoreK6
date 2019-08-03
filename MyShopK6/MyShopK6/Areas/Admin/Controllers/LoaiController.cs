using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyShopK6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}