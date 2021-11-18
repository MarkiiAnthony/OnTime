using Microsoft.AspNetCore.Mvc;
using OnTime.Interfaces;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    public class PunchOutController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IStopwatch _StopwatchService;

        public PunchOutController(ApplicationDbContext db, IStopwatch stopwatchService)
        {
            _StopwatchService = stopwatchService;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PunchTool()
        {



            var punchTool = new PunchClockModel
            {

                PunchedIn = false,
                PunchedOut = true,
                PunchDateTime = DateTime.Now,
                Employee = User.FindFirstValue(ClaimTypes.Name),
                HoursWorked = _StopwatchService.StopTimer(),

            };

            _db.Add(punchTool);
            _db.SaveChanges();



            return RedirectToAction("Index", "Dashboard");
        }
    }
}
