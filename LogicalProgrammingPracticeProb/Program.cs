using System;

namespace LogicalProgrammingPracticeProb
{
    class Program
    {
        static void Main(string[] args)
        {
            int options;
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Choose 1.FibonacciSeries 2.PerfectNumber");
                options = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (options)
                    {
                        case 1:
                            FibonacciSeries fibonacciSeries = new FibonacciSeries();
                            fibonacciSeries.PrintFibonacciNum(0,1,1,15);
                            break;
                        case 2:PerfectNumber perfectNumber = new PerfectNumber();
                            perfectNumber.CheckPerfectNum(28);
                            break;
                        default:
                            isExit = true;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose valid option");
                }
                
            }
        }
                
           
        
    }
}
