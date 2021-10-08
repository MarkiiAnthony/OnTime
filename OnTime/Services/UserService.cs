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

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }


        public ApplicationUser GetByPin(int pin)
        {
            {
                return null;
            }
        }
    }
}
