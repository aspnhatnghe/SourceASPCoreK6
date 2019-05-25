using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D05_MVCBasic.Models;
using Microsoft.AspNetCore.Mvc;

namespace D05_MVCBasic.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Edit(int mahh)
        {
            Product sp = FindById(mahh);
            if(sp != null)//tìm thấy
            {
                return View(sp);
            }

            //chuyển về Action Index
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(int mahh, Product sp)
        {
            Product item = FindById(mahh);
            if(item != null)
            {
                item.Name = sp.Name;
                item.Quantity = sp.Quantity;
                item.Price = sp.Price;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Product sp = FindById(id);
            if (sp != null)//tìm thấy
            {
                danhSach.Remove(sp);
            }
            return RedirectToAction("Index");
        }
        private Product FindById(int id)
        {
            //dùng LINQ để hỗ trợ tìm kiếm trên mảng
            //.SingleOrDefault(): trả về duy nhất 1 phần tử hoặc NULL
            return danhSach.SingleOrDefault(p => p.Id == id); 
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product sp)
        {
            danhSach.Add(sp);
            return View("Index", danhSach);
        }

        //Tạo danh sách sản phẩm
        static List<Product> danhSach = new List<Product>();
        public IActionResult Index()
        {   
            return View(danhSach);
        }
    }
}