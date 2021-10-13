using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    public class DashboardController : Controller
    {
        private readonly INotyfService _notify;
        private readonly ApplicationDbContext _db;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        RoleManager<IdentityRole> _roleManager;

        public DashboardController( ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, INotyfService notify)
        {
            
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _notify = notify;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {




                _notify.Success("Welcome " + User.Identity.Name + " !");
                return View();



            }
            else
            {
                return View("~/Views/Account/Login.cshtml");
            }
        }

        public IActionResult Schedule()
        {
            return View();
        }
    }
}
