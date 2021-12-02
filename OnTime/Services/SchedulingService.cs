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
    public class SchedulingService : ISchedulingService
    {
        private readonly ApplicationDbContext _db;

        public SchedulingService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> AddUpdate(SchedulingVM model)
        {

            var shiftDate = DateTime.Parse(model.ShiftDate);
            var shiftEndDate = DateTime.Parse(model.ShiftDateEnd).AddMinutes(Convert.ToDouble(model.ShiftDuration));
           
            if (model!=null && model.Id > 0)
            {
                //Update
                return 1;
            }
            else
            {
                //Create
                SchedulerModel schedule = new SchedulerModel()
                {
                    Employee = model.Employee,
                    ShiftDate = shiftDate,
                    ShiftDateEnd = shiftEndDate,
                   
                    IsApproved = model.IsApproved,
                    ShiftDuration = model.ShiftDuration,
                    startTime = model.startTime,
                    StartWeek = model.StartWeek,
                    EndWeek = model.EndWeek,
                    ManagerId = model.ManagerId,
                    EmployeeId = model.EmployeeId,
                    ShiftType = model.ShiftType,
                   



                };
                _db.Schedules.Add(schedule);
               await  _db.SaveChangesAsync();
                return 2;
            }
            
        }

        public List<ApplicationUser> GetAllUsers()
        {
            var Users = (from user in _db.Users
                         select new ApplicationUser
                         {
                             Id = user.Id,
                             Name = user.Name,
                             UserRole = user.UserRole,
                             HireDate = user.HireDate,

                         }).ToList();
            return Users;
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
            var ITadmins = (from user in _db.Users
                            join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                            join roles in _db.Roles.Where(x => x.Name == Helper.ITadmin) on userRoles.RoleId equals roles.Id
                            select new ITadminVM
                            {
                                Id = user.Id,
                                Name = user.Name,
                            }).ToList();
            return ITadmins;
        }

        public List<ManagerVM> GetManagerList()
        {
            var Managers = (from user in _db.Users
                            join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                            join roles in _db.Roles.Where(x => x.Name == Helper.Manager) on userRoles.RoleId equals roles.Id
                            select new ManagerVM
                            {
                                Id = user.Id,
                                Name = user.Name,
                            }).ToList();
            return Managers;
        }

        
    }
}
