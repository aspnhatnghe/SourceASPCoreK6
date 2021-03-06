﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D07_UploadFile_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace D07_UploadFile_Validation.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(EmployeeInfo info)
        {
            return View();
        }

        public IActionResult Employee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Employee(EmployeeInfo emp)
        {
            //dữ liệu hợp lệ trên server
            if (ModelState.IsValid)
            {
                //todo xyz
                ModelState.AddModelError("tb", "Hợp lệ nhé");
            }
            else
            {
                ModelState.AddModelError("loi", "Còn lỗi");
            }
            return View();
        }
    }
}