using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Interfaces
{
    public interface IUser
    {
        ApplicationUser GetByPin(int pin);
    }
}
