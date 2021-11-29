using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTime.Interfaces
{
    public interface IReport
    {
        public byte[] GeneratePdfReport();
    }
}
