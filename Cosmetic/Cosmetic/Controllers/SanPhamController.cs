using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using Cosmetic.Models;

namespace Cosmetic.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly MyPhamContext db;
        public SanPhamController(MyPhamContext context)
        {
            db = context;
        }


        [Route("san-pham/{loai}")]
        public async Task<IActionResult> Index(string loai, int page = 1)
        {

            var qry = db.SanPham.AsNoTracking().OrderBy(p => p.MaSp);
            var model = await PagingList.CreateAsync(qry, 9, page);
            if (loai != null)
            {
                ViewBag.Loai = db.Loai.SingleOrDefault(p => p.TenLoaiSeoUrl == loai);
                Loai qery1 = db.Loai.SingleOrDefault(p => p.TenLoaiSeoUrl == loai);
                var qery = db.SanPham.Where(p => p.MaLoai == qery1.MaLoai).AsNoTracking().OrderBy(p => p.MaSp);

                var md = await PagingList.CreateAsync(qery, 9, page);
                return View(md);
            }

            return View(model);
        }

        [Route("{loai}/{url}")]
        public IActionResult ChiTiet(string loai, string url)
        {
            if (loai != null)
            {
                ViewBag.Loai = db.Loai.SingleOrDefault(p => p.TenLoaiSeoUrl == loai);
            }
            SanPham hh = db.SanPham.SingleOrDefault(p => p.TenSpSeoUrl == url);
            if (hh == null)
            {
                return RedirectToAction("Index");
            }
            return View(hh);
        }
    }
}