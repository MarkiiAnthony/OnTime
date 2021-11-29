using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    public class SchedulerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScheduleManager()
        {
            return View();
        }
    }
}
