using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D13_ADONET.Models;
using Microsoft.AspNetCore.Mvc;

namespace D13_ADONET.Controllers
{
    public class LoaiController : Controller
    {
        public IActionResult Index()
        {
            return View(LoaiDAO.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Loai lo)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            if (lo.MoTa == null) lo.MoTa = "";
            if (lo.Hinh == null) lo.Hinh = "";

            int result = LoaiDAO.AddLoai(lo);
            if (result == 0)//thất bại
            {
                return View();
            }
            //chuyển tới màn hình Edit loại
            return RedirectToAction("Edit", new { id = result});
        }

        public IActionResult Edit(int id)
        {
            Loai lo = LoaiDAO.GetLoai(id);
            if(lo != null)
            {
                return View(lo);
            }
            //nếu ko có thì trở về màn hình Index
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(int id, Loai lo)
        {
            if (id != lo.MaLoai)
                return View();

            //dựa vào mã đi kiếm loại đang có trong database
            Loai loai = LoaiDAO.GetLoai(id);
            if(loai != null)
            {
                //thực hiện sửa và cập nhật
                loai.TenLoai = lo.TenLoai;
                loai.MoTa = lo.MoTa;
                loai.Hinh = lo.Hinh;
                LoaiDAO.UpdateLoai(loai);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Loai loai = LoaiDAO.GetLoai(id);
            bool result = false;
            if (loai != null)
            {
                result = LoaiDAO.DeleteLoai(id);
            }

            ViewBag.ThongBao = $"Xóa loại {id}-{loai.TenLoai} {(result ? "thành công" : "thất bại")}";

            return RedirectToAction("Index");
        }
    }
}