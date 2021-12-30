using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OnTime.Controllers
{
    public class PTOController : Controller
    {
        private readonly ApplicationDbContext _db;
        SignInManager<ApplicationUser> _signInManager;

        public PTOController(ApplicationDbContext db, SignInManager<ApplicationUser> signInManager)
        {
            _db = db;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var user = User.Identity.Name;
            var PtoResult = _db.Users.Where(x => x.UserName == user)
                  .Select(x => x.PaidTimeOff).FirstOrDefault();

            ViewData["PTOData"] = PtoResult;

            return View();
        }
        public IActionResult TimeOffRequest()

        {
            return View();

        }

      

        [HttpPost]
        public IActionResult SubmitPTO(PTORequests PtoRequestModel)

        {
            var ptorequested = new PTORequests
            {
                PtoType = PtoRequestModel.PtoType,
                PtoStartDate= PtoRequestModel.PtoStartDate,
                HoursRequested = PtoRequestModel.HoursRequested,
                EmployeeName = User.Identity.Name,

            };

            _db.Add(ptorequested);
            _db.SaveChanges();

            return RedirectToAction("PtoConfirmation","Confirmations");
        }
    }
}
