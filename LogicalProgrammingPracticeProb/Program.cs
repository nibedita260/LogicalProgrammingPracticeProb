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
                Console.WriteLine("Choose 1.FibonacciSeries 2.PerfectNumber 3.PrimeNumber 4.ReverseNumber");
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
                        case 3:PrimeNumber primeNumber = new PrimeNumber();
                            primeNumber.CheckPrimeNumber(57);
                            break;
                        case 4:ReverseNumber reverseNumber = new ReverseNumber();
                            reverseNumber.PrintReverseofNum(121);
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
