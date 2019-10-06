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


    }
}