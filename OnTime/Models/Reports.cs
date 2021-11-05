using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models
{
    public class Reports
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Name")]

        public virtual ApplicationUser username { get; set; }
        public IEnumerable<Attendance> Attendances { get; set; }




    }
}
