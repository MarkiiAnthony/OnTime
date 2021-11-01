using Microsoft.AspNetCore.Mvc;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    
        public class PunchInController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PunchInController( ApplicationDbContext db)
        {

        }
            public IActionResult Index()
        {
            return View();
        }

        public IActionResult PunchTool()
        {
            return View();
        }
    }
}
