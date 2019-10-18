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
        private IDataProtector _protector;
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
            string key = "Cyg-X1"; //key to encrypt and decrypt
            Encrytion ecr = new Encrytion();  
                       
            string passold = HttpContext.Request.Form["nhapmkcu"].ToString();
            string pass1 = HttpContext.Request.Form["nhapmk"].ToString();
            string pass2 = HttpContext.Request.Form["nhaplaimk"].ToString();            
            
            if(pass1 != pass2 || passold != ecr.DecryptText(kh.MatKhau,key))
            {
                ViewBag.Result = "Mật khẩu không khớp!";
            }
            else
            {
                var query = from info in db.KhachHang
                            where info.MaKh == kh.MaKh
                            select info;

                foreach (KhachHang ds in query)
                {
                    ds.MatKhau = ecr.EncryptText(pass2,key);
                    ViewBag.Result = "Đã đổi mật khẩu thành công!";
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewBag.Result = "Có lỗi xảy ra" + e;
                }
                kh.MatKhau = pass1;
                HttpContext.Session.Set("TaiKhoan", kh);
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
