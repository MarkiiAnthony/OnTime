using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenerateReport()
        {

            return RedirectToAction("WeeklyReports", "Reports");
        }

        public IActionResult WeeklyReports()
        {
            return new ViewAsPdf();
        }
    }
}
