using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetic.Models;
using Microsoft.AspNetCore.DataProtection;
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
            
            string passold = HttpContext.Request.Form["nhapmkcu"].ToString();
            string pass1 = HttpContext.Request.Form["nhapmk"].ToString();
            string pass2 = HttpContext.Request.Form["nhaplaimk"].ToString();            
            
            if(pass1 != pass2 || passold != kh.MatKhau)
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
                    ds.MatKhau = pass2;
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
