using Microsoft.AspNetCore.Mvc;
using OnTime.Models;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ReportsController(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenerateReport()
        {

            return RedirectToAction("Reports", "Reports");
        }

        public IActionResult Reports()
        {
            IEnumerable<PunchClockModel> PunchLogList = _db.PunchClock;

            return new ViewAsPdf(PunchLogList);
        }
    }
}
