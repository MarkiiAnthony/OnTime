using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models
{
    public class ApplicationRoles
    {
        [Key]
        public int roleID { get; set; }

       public string roleName { get; set; }


    }
}
