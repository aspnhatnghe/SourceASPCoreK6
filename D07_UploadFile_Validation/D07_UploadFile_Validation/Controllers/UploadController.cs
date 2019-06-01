using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace D07_UploadFile_Validation.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadFile(string Ten, IFormFile myfile)
        {
            //nếu có file gửi lên và có nội dung
            if (myfile != null && myfile.Length > 0)
            {
                try
                {
                    //tạo đường dẫn tới nơi lưu file
                    string fullPath = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot", "Data",
                $"_{DateTime.Now.Ticks}{myfile.FileName}");

                    //tạo file trống
                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        //copy nội dung file
                        myfile.CopyTo(file);
                    }
                    ViewBag.ThongBao = $"Upload file {myfile.FileName} thành công";
                }
                catch (Exception ex)
                {
                    ViewBag.ThongBao = $"Lỗi: {ex.Message}";
                }
            }

            return View("Index");
        }

        public IActionResult UploadFiles(List<IFormFile> myfile)
        {
            try
            {
                foreach(var f in myfile)
                {
                    string fullPath = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot", "Data",
            $"_{DateTime.Now.Ticks}{f.FileName}");

                    //tạo file trống
                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        //copy nội dung file
                        f.CopyTo(file);
                    }
                }                
                
                ViewBag.Message = $"Upload {myfile.Count} file thành công";
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Lỗi: {ex.Message}";
            }


            return View("Index");
        }

        public IActionResult ShowFiles()
        {
            string fullPath = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot", "Data");
            string[] files = Directory.GetFiles(fullPath);

            return View(files);
        }
    }
}