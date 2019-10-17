using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmetic.Models;

namespace Cosmetic.Controllers
{
public class KhachHangController : Controller
    {
        private readonly MyPhamContext db;
        public KhachHangController(MyPhamContext context)
        {
            db = context;
        }
        [Route("KhachHang")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
