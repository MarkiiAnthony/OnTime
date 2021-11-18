using OnTime.Interfaces;
using OnTime.Models;
using OnTime.Models.Viewmodels;
using OnTime.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<CashierVM> GetCashierList()
        {
            var cashiers = (from user in _db.Users
                            join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                            join roles in _db.Roles.Where(x=>x.Name == Helper.Cashier) on userRoles.RoleId equals roles.Id
                           select new CashierVM
                           {
                               Id = user.Id,
                               Name = user.Name,
                           }).ToList();
            return cashiers;
        }

        public List<ITadminVM> GetITadminList()
        {
            throw new NotImplementedException();
        }

        public List<ManagerVM> GetManagerList()
        {
            throw new NotImplementedException();
        }
    }
}
