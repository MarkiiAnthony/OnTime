using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Utility
{
    public static class Helper
    {
        public static string ITadmin = "ITadmin";
        public static string Manager = "Manager";
        public static string Cashier = "Cashier";

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Cashier,Text=Helper.Cashier},
                new SelectListItem{Value=Helper.ITadmin,Text=Helper.ITadmin},
                new SelectListItem{Value=Helper.Manager,Text=Helper.Manager},

            };

        }
    }
}
