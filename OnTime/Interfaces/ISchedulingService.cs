using OnTime.Models.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnTime.Models;

namespace OnTime.Interfaces
{
   public  interface ISchedulingService
    {
        public List<ITadminVM> GetITadminList();
        public List<ManagerVM> GetManagerList();

        public List<CashierVM> GetCashierList();

        public List<ApplicationUser> GetAllUsers();

        public  Task InsertSchedule(SchedulerModel schedule );

        public List<ScheduleViewModel> GetSchedule();

    }
}
