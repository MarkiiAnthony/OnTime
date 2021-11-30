using Microsoft.AspNetCore.Mvc;
using OnTime.Interfaces;
using OnTime.Models;
using OnTime.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    public class SchedulerController : Controller
    {
        private readonly ISchedulingService _schedulingService;


        public SchedulerController(ISchedulingService schedulingService)
            {
            _schedulingService = schedulingService;
            }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScheduleManager()
        {
            ViewBag.Duration = Helper.GetShiftLength();
            ViewBag.UserList = _schedulingService.GetAllUsers();
            IEnumerable<ApplicationUser> users = _schedulingService.GetAllUsers();

            return View(users);
        }
    }
}
