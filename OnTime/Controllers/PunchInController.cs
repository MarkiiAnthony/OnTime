﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    
        public class PunchInController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PunchInController( ApplicationDbContext db)
        {
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

                PunchedIn = true,
                PunchedOut = false,
                PunchDateTime = DateTime.Now,


                };

                _db.Add(punchTool);
                _db.SaveChanges();
           

         
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
