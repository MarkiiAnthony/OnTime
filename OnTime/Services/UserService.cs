using Microsoft.AspNetCore.Identity;
using OnTime.Interfaces;
using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Services
{

    public class UserService : IUser
    {
        private readonly ApplicationDbContext _db;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserService(ApplicationDbContext db, SignInManager<ApplicationUser> signinManager )
        {
            _db = db;
            _signInManager = signinManager;
        }

        public List<PTORequests> GetAllPtoRequests()
        {
            var requests = (from request in _db._Ptorequests
                         select new PTORequests
                         {
                             PtoStartDate = request.PtoStartDate,
                             HoursRequested = request.HoursRequested,
                             EmployeeName = request.EmployeeName,
                             Id = request.Id,

                            

                         }).ToList();
            return requests;
        }

        public List<EmpAvailability> GetAllavailability()
        {
            var availability = (from avail in _db.AvailabilityNotes
                            select new EmpAvailability 
                            { 
                                AvailabilityNote = avail.AvailabilityNote,
                                EmployeedId = avail.EmployeedId,


                            }).ToList();
            return availability;
        }
    }
}
