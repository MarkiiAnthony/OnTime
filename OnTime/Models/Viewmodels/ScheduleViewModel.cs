using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models.Viewmodels
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }


        public string startTime { get; set; }

        public string EndTime { get; set; }


        public string Employee { get; set; }

        public string ShiftType { get; set; }
    }
}
