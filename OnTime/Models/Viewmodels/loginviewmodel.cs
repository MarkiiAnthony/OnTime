using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models.Viewmodels
{
    public class loginviewmodel
    {
        [Required]
        public string EmployeePin{ get; set; }
        public string name { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
