using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models
{
    public class SchedulerModel
    {

        public int? Id { get; set; }
        public int ShiftDuration { get; set; }
    

        public string startTime { get; set; }


        public string Employee { get; set; }

        public string ShiftType { get; set; }
 

        public DateTime  ShiftDate{ get; set; }
   
        public DateTime ShiftDateEnd { get; set; }


        public DateTime StartWeek { get; set; }
        public DateTime EndWeek { get; set; }

        public string EmployeeId { get; set; }

        public bool IsApproved { get; set; }

     #nullable enable
        public string? ManagerId { get; set; }
    }
}
