using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models
{
    public class PunchClockModel
    {
        [Key]
        public int PunchID { get; set; }
        public Boolean PunchedIn { get; set; }
        public Boolean PunchedOut { get; set; }
       
    }
}
