using System;
using System.Collections.Generic;
using System.Text;


namespace LogicalProgrammingPracticeProb
{
    class StimulateStopWatch
    {
        private static readonly int Elapsed;

        public void PrintElapseTime()
        {
            StimulateStopWatch timer = new StimulateStopWatch();
            timer.Start();
            for(int i = 1; i < 1000; i++)
            {
                if (i == 200)
                    break;
            }
            timer.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", StimulateStopWatch.Elapsed);
        }

        private object Stop()
        {
            throw new NotImplementedException();
        }

        private void Start()
        {
            throw new NotImplementedException();
        }
    }
}
