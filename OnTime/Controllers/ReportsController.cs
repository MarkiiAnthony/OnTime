using Microsoft.AspNetCore.Mvc;
using OnTime.Interfaces;
using OnTime.Models;
using OnTime.Models.Viewmodels;
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
        private readonly ISchedulingService _schedulingService;
        public ReportsController(ApplicationDbContext db, ISchedulingService schedulingService)
        {
            _db = db;
            _schedulingService = schedulingService;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenerateReport()
        {

            return RedirectToAction("PunchReport", "Reports");
        }

        public IActionResult PunchReport()
        {
            IEnumerable<PunchClockModel> PunchLogList = _db.PunchClock;
           



            return new ViewAsPdf(PunchLogList);
        }
        public IActionResult UsersReport()
        {

            IEnumerable<ApplicationUser> userList = _schedulingService.GetAllUsers();



            return new ViewAsPdf(userList);
        }
        
    }
}
