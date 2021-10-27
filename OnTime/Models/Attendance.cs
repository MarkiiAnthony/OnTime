using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Models
{
    public class Attendance
    {
        //Foreign Key
        [Key]
       [Display(Name ="Username")]
       public virtual string Name { get; set; }

       [ForeignKey("Name")]

       public virtual ApplicationUser username { get; set;}

        public int DaysPresent { get; set; }
        public int DaysAbsent { get; set; }

        public int ontimePercentage { get; set; }

     
    }
}
