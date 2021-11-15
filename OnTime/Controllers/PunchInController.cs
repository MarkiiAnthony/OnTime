using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnTime.Interfaces;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    
        public class PunchInController : Controller
    {
        private readonly IStopwatch _StopwatchService;
        private readonly ApplicationDbContext _db;
        UserManager<ApplicationUser> _UserManager;

        public PunchInController( ApplicationDbContext db, UserManager<ApplicationUser> UserManager,IStopwatch stopwatchService)
        {
            _StopwatchService = stopwatchService;
             _db = db;
            _UserManager = UserManager;
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
                 

                 PunchedIn = true,
                PunchedOut = false,
                PunchDateTime = DateTime.Now,
                Employee = User.FindFirstValue(ClaimTypes.Name),

            };
            _StopwatchService.StartTimer();

            _db.Add(punchTool);
            _db.SaveChanges();
           

         
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
