using OnTime.Models.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Interfaces
{
   public  interface IAppointmentService
    {
        public List<ITadminVM> GetITadminList();
        public List<ManagerVM> GetManagerList();

        public List<CashierVM> GetCashierList();
    }
}
