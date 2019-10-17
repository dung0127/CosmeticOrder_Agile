using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetic.Models;

namespace Cosmetic.Controllers
{
    public class ThanhToanController : Controller
    {
        private readonly MyPhamContext db;
        public ThanhToanController(MyPhamContext context)
        {
            db = context;
        }

        [Route("thanh-toan-1")]
        public IActionResult Index()
        {
            HttpContext.Session.Remove("ThongTin");
            return View(Carts);
        }

        public List<CartItem> Carts
        {
            get
            {
                List<CartItem> myCart = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (myCart == default(List<CartItem>))
                {
                    myCart = new List<CartItem>();
                }

                return myCart;
            }
        }


        [Route("thanh-toan-2")]
        public IActionResult ThanhToan1()
        {
            return View(Carts);

        }

        public List<NguoiNhan> ThongTins
        {
            get
            {
                List<NguoiNhan> myInfo = HttpContext.Session.Get<List<NguoiNhan>>("ThongTin");
                if (myInfo == default(List<NguoiNhan>))
                {
                    myInfo = new List<NguoiNhan>();
                }

                return myInfo;
            }
        }

        //Lưu thông tin người nhận

        [Route("[controller]/[action]")]
        public IActionResult Them(string tennn, string sdtnn, string diachinn, string ghichunn)
        {
            List<NguoiNhan> thongTin = ThongTins;

            NguoiNhan item = thongTin.SingleOrDefault();
            if (item == null)
            {

                item = new NguoiNhan
                {
                    TenNhan = tennn,
                    SDTNhan = sdtnn,
                    DiaChiNhan = diachinn,
                    GhiChu = ghichunn,
                };
                thongTin.Add(item);

            }
            //lưu session
            HttpContext.Session.Set("ThongTin", thongTin);
            return RedirectToAction("ThanhToan1", "ThanhToan");
        }

      

    }
}