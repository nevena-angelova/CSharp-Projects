using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FCMD.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FCMD.Data;

namespace FCMD.Web.Controllers
{
    public class HomeController : Controller
    {
        private FcmdDbContext db;

        public HomeController(FcmdDbContext context)
        {
            this.db = context;
        }


        public IActionResult Index()
        {

            var cats = db.Cats.ToList();

            return View(cats);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
