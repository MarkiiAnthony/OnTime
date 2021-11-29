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
        private readonly IAppointmentService _schedulingService;
        public ReportsController(ApplicationDbContext db, IAppointmentService schedulingService)
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

            return RedirectToAction("Reports", "Reports");
        }

        public IActionResult Reports()
        {
            IEnumerable<PunchClockModel> PunchLogList = _db.PunchClock;
            IEnumerable<CashierVM> cashierList = _schedulingService.GetCashierList();
            IEnumerable<ITadminVM> ITadminList = _schedulingService.GetITadminList();
            IEnumerable<ManagerVM> managerList = _schedulingService.GetManagerList();



            return new ViewAsPdf(PunchLogList);
        }
    }
}
