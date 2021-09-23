using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalProgrammingPracticeProb
{
    class StimulateStopWatch
    {
        public void PrintElapseTime()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(5);
            }
            timer.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", timer.Elapsed);
        }
    }
}
