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
             _db = db;
        }
            public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PunchTool()
        {
            var punchToolCheck = _db.PunchClock.Where(x => x.PunchedIn == true);

            if (punchToolCheck == null)
            {
                var punchTool = new PunchClockModel
                {

                    PunchedIn = true,
                    PunchedOut = false,

                };

                _db.Add(punchTool);
                _db.SaveChanges();
            }

            else
            {
                var punchTool = new PunchClockModel
                {

                    PunchedIn = false,
                    PunchedOut = true,

                };

                _db.Add(punchTool);
                _db.SaveChanges();
            }
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
