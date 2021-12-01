using Microsoft.AspNetCore.Mvc.Rendering;
using OnTime.Interfaces;
using OnTime.Models;
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
        public static string scheduleAdded = "Schedule added successfully.";
        public static string scheduleUpdated = "Schedule updated successfully.";
        public static string scheduleDeleted = "Schedule deleted successfully.";
        public static string scheduleExists = "Schedule already exists.";
        public static string Error = "Something went wrong please try again.";
        public static int success_code = 1;
        public static int failure_code = 0;

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Cashier,Text=Helper.Cashier},
                new SelectListItem{Value=Helper.ITadmin,Text=Helper.ITadmin},
                new SelectListItem{Value=Helper.Manager,Text=Helper.Manager},

            };

        }

        public static List<SelectListItem> GetShiftLength()
        {
            int minute = 60;
            List<SelectListItem> duration = new List<SelectListItem>();
            for (int i = 1; i<=10; i++)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hr" });
                minute = minute + 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hr 30 min" });
                minute = minute + 30; 
            }
            return duration;

        }
    }
}
