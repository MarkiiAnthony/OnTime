using Microsoft.AspNetCore.Mvc;
using OnTime.Interfaces;
using OnTime.Models;
using System.Collections.Generic;

namespace OnTime.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUser _userServerice;

        public AdminController(ApplicationDbContext db, IUser userService)
        {
            _db = db;
            _userServerice = userService;
        }

        public IActionResult Index()
        {
            

            return View();
        }
        public IActionResult ptoadmin()
        {
            IEnumerable<PTORequests> ptorequests = _userServerice.GetAllPtoRequests();

            return View(ptorequests);
        }

        public IActionResult ptoavailability()
        {
            IEnumerable<EmpAvailability> ptorequests = _userServerice.GetAllavailability();

            return View(ptorequests);
        }
        [HttpPost]
        public IActionResult postavailability(EmpAvailability model)
        {
            var Aval = new EmpAvailability
            {
                AvailabilityNote = model.AvailabilityNote,
                EmployeedId = User.Identity.Name,

            };
            _db.Add(Aval);

            _db.SaveChanges();

            return RedirectToAction("Index", "Dashboard");
        }

        [HttpPost]
        public IActionResult ptoApproval(PTORequests model)

        {
            var ptorequest = new PTORequests
            {
                Id =model.Id,
                ptoapproval = true,
            };

           


            return RedirectToAction("Admin", "ptoadmin");

        }

        [HttpPost]
        public IActionResult ptoDenial()

        {
            return RedirectToAction("Admin", "ptoadmin");

        }
    }
}
