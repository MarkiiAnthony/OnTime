
using Microsoft.EntityFrameworkCore;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace OnTime.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>  
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

     
    }
}
