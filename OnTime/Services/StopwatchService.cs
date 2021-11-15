using OnTime.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnTime.Services
{
    public class StopwatchService : IStopwatch
    {
        public TimeSpan StartTimer()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(10000);

            return stopWatch.Elapsed;
        }

        public TimeSpan StopTimer()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Stop();
            Thread.Sleep(10000);

            return stopWatch.Elapsed; 

        }
    }
}
