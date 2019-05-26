using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using D06_MVCBasic.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace D06_MVCBasic.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            List<HangHoa> ds = new List<HangHoa>();
            ds.Add(new HangHoa {
                MaHh = 1, TenHh = "IPhone XS",
                DonGia = 17900, SoLuong = 13,
                Hinh = "iphone-x-64gb.png"
            });
            ds.Add(new HangHoa {
                MaHh = 2, TenHh = "Note 8",
                DonGia = 10990, SoLuong = 13,
                Hinh = "samsung-galaxy-note8-black.png"
            });
            ViewBag.HangHoa = ds;
            return View();
        }

        public IActionResult DocGhiFile()
        {
            return View();
        }

        string txt = "HangHoa.txt";
        string json = "HangHoa.json";
        [HttpPost]
        public IActionResult DocGhiFile(HangHoa hh, string Ghi)
        {
            try
            {
                if (Ghi == "Ghi file text")
                {
                    string[] content = {
                    hh.MaHh.ToString(),
                    hh.TenHh, hh.Hinh,
                    hh.DonGia.ToString(),
                    hh.SoLuong.ToString()
                };

                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HangHoa.txt");

                    System.IO.File.WriteAllLines(fullPath, content);
                    ViewBag.ThongBao = "Ghi file text thành công";
                }
                else if (Ghi == "Ghi file JSON")
                {
                    //chuyển object sang chuỗi json
                    string jsonString = JsonConvert.SerializeObject(hh);

                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HangHoa.json");

                    System.IO.File.WriteAllText(fullPath, jsonString);
                    ViewBag.ThongBao = "Ghi file json thành công";
                }
            }
            catch
            {
                ViewBag.Loi = "Có lỗi ghi file";
            }
            return View();
        }

        public IActionResult ReadTextFile()
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HangHoa.txt");
            string[] content = System.IO.File.ReadAllLines(fullPath);

            //convert jsonString to object
            HangHoa hh = new HangHoa {
                MaHh = int.Parse(content[0]),
                TenHh = content[1],
                Hinh = content[2],
                DonGia = double.Parse(content[3]),
                SoLuong = int.Parse(content[4])
            };

            ViewBag.HangHoa = hh;
            return View("DocGhiFile");
        }

        public IActionResult ReadJsonFile()
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HangHoa.json");
            string content = System.IO.File.ReadAllText(fullPath);

            //convert jsonString to object
            HangHoa hh = JsonConvert.DeserializeObject<HangHoa>(content);

            ViewBag.HangHoa = hh;
            return View("DocGhiFile");
        }

        public string Sync()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Demo demo = new Demo();
            demo.Test01();
            demo.Test02();
            demo.Test03();
            sw.Stop();

            return $"Chạy hết {sw.ElapsedMilliseconds} ms";
        }

        public async Task<IActionResult> Async()
        {
            Stopwatch sw = new Stopwatch();
            Demo demo = new Demo();
            sw.Start();
            var a = demo.Test01Async();
            var b = demo.Test02Async();
            var c = demo.Test03Async();
            await a; await b; await c;
            sw.Stop();
            return Content($"Chạy hết {sw.ElapsedMilliseconds} ms.");
        }
    }
}