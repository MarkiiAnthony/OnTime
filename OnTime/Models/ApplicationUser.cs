using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models
{
    public class ApplicationUser : IdentityUser 
    {
       
        public string Name { get; set; }
  

        public string ProfileImageUrl { get; set; }

        public string DOB { get; set; }

        public string HireDate { get; set; }
        public int HoursWorked { get; set; }
        public double  PaidTimeOff { get; set; }
        public string PtoRequested{ get; set; }
        public string UserRole { get; set; }



    }
}
