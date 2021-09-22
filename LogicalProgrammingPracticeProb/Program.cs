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
                Console.WriteLine("Choose 1.FibonacciSeries");
                options = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (options)
                    {
                        case 1:
                            FibonacciSeries fibonacciSeries = new FibonacciSeries();
                            fibonacciSeries.PrintFibonacciNum(0,1,1,15);
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
