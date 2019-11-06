using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cosmetic.Models;

namespace Cosmetic.Controllers
{
    public class SanPhamsController : Controller
    {
        private readonly MyPhamContext _context;

        public SanPhamsController(MyPhamContext context)
        {
            _context = context;
        }

        // GET: SanPhams
        public async Task<IActionResult> Index()
        {
                var myPhamContext = _context.SanPham.Include(s => s.MaLoaiNavigation).Include(s => s.MaNccNavigation);
                return View(await myPhamContext.ToListAsync());
        }

        // GET: SanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {

                if (id == null)
                {
                    return NotFound();
                }

                var sanPham = await _context.SanPham
                    .Include(s => s.MaLoaiNavigation)
                    .Include(s => s.MaNccNavigation)
                    .FirstOrDefaultAsync(m => m.MaSp == id);
                if (sanPham == null)
                {
                    return NotFound();
                }

                return View(sanPham);
 
        }



        


    }
}