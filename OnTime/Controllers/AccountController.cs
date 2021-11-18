using OnTime.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnTime.Models.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnTime.Interfaces;
using AspNetCoreHero.ToastNotification.Abstractions;
using OnTime.Utility;

namespace OnTime.Controllers
{
    public class AccountController : Controller
    {
        private readonly INotyfService _notify;
        private readonly ApplicationDbContext _db;
        private readonly IUser _userService;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        RoleManager<IdentityRole> _roleManager;
       

        public AccountController(IUser userService, ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager,INotyfService notify)
        {
            _userService = userService;
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _notify = notify;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {




                return View("~/Views/Dashboard/Index.cshtml");
                



            }
            else
            {
                return View();
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(loginviewmodel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Dashboard");



                }
                ModelState.AddModelError("", "Invalid Login Attempt");
            }
            return View(model);
        }

        public async Task<IActionResult> Register()
        {
            if (!_roleManager.RoleExistsAsync(Helper.ITadmin).GetAwaiter().GetResult())
            {
               await  _roleManager.CreateAsync(new IdentityRole(Helper.ITadmin));
                await _roleManager.CreateAsync(new IdentityRole(Helper.Manager));
                await _roleManager.CreateAsync(new IdentityRole(Helper.Cashier));

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Registerviewmodel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Name = model.Name,
                    PaidTimeOff = 40.00,
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    await _userManager.AddToRoleAsync(user, model.roleName);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Dashboard");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                var userInfouser = User.Identity.Name;
                ViewBag["UserId"] = _db.Users.Where(x => x.UserName == userInfouser)
                  .Select(x => x.Id);
            }
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Logoff()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account");



        }
        public IActionResult Profile()
        {
            return View();
        }

    }
}

