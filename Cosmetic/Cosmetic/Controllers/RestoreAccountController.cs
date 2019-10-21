using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetic.Controllers
{
    public class RestoreAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}