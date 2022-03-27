using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class SimulateStopWatch
    {
        public void StopWatch()
        {
            Console.WriteLine("Welcome to Stop Watch Simulator");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2);
            }
            stopwatch.Stop();
            Console.WriteLine("End");
            Console.WriteLine("Time elapsed: {0}",
                stopwatch.Elapsed);
            Console.ReadLine();
        }
        
    }
}
