using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetic.Controllers
{
    public class DangNhapController : Controller
    {
        private readonly MyPhamContext db;
        public DangNhapController(MyPhamContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("[controller]/[action]")]
        public IActionResult DangNhap(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                KhachHang kh = db.KhachHang.SingleOrDefault(p => p.MaKh == model.MaKh && p.MatKhau == model.MatKhau);
                if (kh == null)
                {
                    ModelState.AddModelError("Loi", "Thông tin tài khoản hoặc mật khẩu không hợp lệ.");
                    return View("Index");
                }
                HttpContext.Session.Set("TaiKhoan", kh);
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }

        [Route("[controller]/[action]")]
        public IActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        public async Task<IActionResult>DangKy([Bind("MaKh,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,HieuLuc,VaiTro,RandomKey")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                db.Add(khachHang);
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(khachHang);
        }
        [Route("[controller]/[action]")]
        public IActionResult DangXuat()
        {
            //xóa session
            HttpContext.Session.Remove("TaiKhoan");
            return RedirectToAction("Index", "Home");
        }
    }
}