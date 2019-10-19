using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetic.Models;
using Microsoft.AspNetCore.DataProtection;
using Cosmetic.Encrytions;

namespace Cosmetic.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly MyPhamContext db;
        Encrytion ecr = new Encrytion();
        private IDataProtector _protector;
        //private string key = "Cyg-X1"; //key to encrypt and decrypt
        public KhachHangController(MyPhamContext context, IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Contoso.MyClass.v1");
            db = context;
        }
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[controller]/[action]")]
        public IActionResult DoiMK()
        {
            KhachHang kh = HttpContext.Session.Get<KhachHang>("TaiKhoan");
            PasswordHasher passwordHasher = new PasswordHasher(); 
                       
            string passold = HttpContext.Request.Form["nhapmkcu"].ToString();
            string pass1 = HttpContext.Request.Form["nhapmk"].ToString();
            string pass2 = HttpContext.Request.Form["nhaplaimk"].ToString();            
            
            if(pass1 != pass2 || 
            passwordHasher.VerifyHashedPassword(kh.MatKhau, passold) == PasswordVerificationResult.Failed)
            {
                ViewBag.Result = "Mật khẩu không khớp!";
            }
            else if (passwordHasher.VerifyHashedPassword(kh.MatKhau, passold) == PasswordVerificationResult.ErrorNull)
            {
                ViewBag.Result = "Không được để trống mật khẩu!";
            }
            else
            {
                var query = from info in db.KhachHang
                            where info.MaKh == kh.MaKh
                            select info;

                foreach (KhachHang ds in query)
                {
                    ds.MatKhau = passwordHasher.HashPassword(pass2);
                    kh.MatKhau = ds.MatKhau;
                    ViewBag.Result = "Đã đổi mật khẩu thành công!";
                    HttpContext.Session.Set("TaiKhoan", kh);
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    ViewBag.Result = "Có lỗi xảy ra. Vui lòng liên hệ admin";
                }
            }
            return View("Index");
        }
        [Route("[controller]/[action]")]
        public IActionResult DoiTT()
        {
            return View("Index");
        }
    }
}
