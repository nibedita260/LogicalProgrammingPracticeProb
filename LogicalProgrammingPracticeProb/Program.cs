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
                Console.WriteLine("Choose 1.FibonacciSeries 2.PerfectNumber 3.PrimeNumber 4.ReverseNumber 5.CouponNumber 6.StimulateStopWatch 7.DayOfWeek 8.VendorMachine 9.TemperatureConversion 10.MonthlyPayment 11.SqrtOfNum 12.ToBinary 13.BinarySwapNibblesAndResultantNumber");
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
                        case 5:CouponNumber couponNumber = new CouponNumber();
                            couponNumber.PrintCouponNumber(3);
                            break;
                        case 6:StimulateStopWatch stimulateStopWatch = new StimulateStopWatch();
                            stimulateStopWatch.PrintElapseTime();
                            break;
                        case 7:DayOfWeek dayOfWeek = new DayOfWeek();
                            dayOfWeek.PrintDayOfWeek(1,4,1995);
                            break;
                        case 8:VendingMachine vendorMachine = new VendingMachine();
                            vendorMachine.MinNumberOfNote(1000);
                            break;
                        case 9:TemperatureConversion temperatureConversion = new TemperatureConversion();
                            temperatureConversion.CalTemp(35,"farahenite");
                            break;
                        case 10:MonthlyPayment monthlyPayment = new MonthlyPayment();
                            monthlyPayment.CalMonthlyPayment(597000,5,9.8);
                            break;
                        case 11:SqrtOfNum sqrtOfNum = new SqrtOfNum();
                            sqrtOfNum.CalSqrtOfNum(100);
                            break;
                        case 12:ToBinary toBinary = new ToBinary();
                            toBinary.CalToBinary(5);
                            break;
                        case 13:BinarySwapNibblesAndResultantNumber nibblesAndResultantNumber = new BinarySwapNibblesAndResultantNumber();
                            nibblesAndResultantNumber.PrintSwapNumAndResultantNum(5);
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
