using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
    public class ConfirmationsController : Controller
    {
        public IActionResult PtoConfirmation()
        {
            return View();
        }
    }
}
