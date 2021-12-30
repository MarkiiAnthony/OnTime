using OnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Interfaces
{
    public interface IUser
    {
        public List<PTORequests> GetAllPtoRequests();
        public List<EmpAvailability> GetAllavailability();

    }
}
