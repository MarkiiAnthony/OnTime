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

        public int  HoursRequested { get; set; }

        public DateTime PtoStartDate { get; set; }

    }
}
