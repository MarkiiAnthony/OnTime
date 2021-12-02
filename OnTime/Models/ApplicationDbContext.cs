
using Microsoft.EntityFrameworkCore;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnTime.Models.Viewmodels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace OnTime.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Attendance> Atten { get; set; }
        public DbSet<PunchClockModel> PunchClock { get; set; }

        public DbSet<Reports> _Reports { get; set; }
        public DbSet<PTORequests> _Ptorequests { get; set; }

        public DbSet<SchedulerModel> Schedules { get; set; }


    }

}