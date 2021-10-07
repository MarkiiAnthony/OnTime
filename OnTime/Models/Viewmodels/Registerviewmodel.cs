﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models.Viewmodels
{
    public class Registerviewmodel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]

     
        public string Password { get; set; }

        
        [Display(Name = "Confirm Pin")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public String Position { get; set; }

        public string DOB { get; set; }

        public string HireDate { get; set; }
    }
}
