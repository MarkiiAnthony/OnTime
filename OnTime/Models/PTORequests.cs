using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models
{
    public class PTORequests
    {
        public int Id { get; set; }
        public string PtoType { get; set; }

        public double  HoursRequested { get; set; }

        public DateTime PtoStartDate { get; set; }

        public string EmployeeName { get; set; }

        public bool ptoapproval { get; set; }
    }
}
