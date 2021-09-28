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
        public int EmployeePin { get; set; }

        public string ProfileImageUrl { get; set; }
    }
}
