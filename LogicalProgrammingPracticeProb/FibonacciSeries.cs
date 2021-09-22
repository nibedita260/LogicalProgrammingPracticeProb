using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class FibonacciSeries
    {
        //Fibonacci series -> 0 1 1 2 3 5 8 13 21 34 55 ....
        public void PrintFibonacciSeries(int n)
        {
            int fib1 = 0, fib2 = 1, fibNum;
            Console.WriteLine("Fibonacci Series of " + n + " are: ");
            Console.Write(fib1 + " " + fib2 + " ");
            for (int i = 2; i < n; i++)
            {
                fibNum = fib1 + fib2;
                Console.Write(fibNum + " ");
                fib1 = fib2;
                fib2 = fibNum;
            }
            Console.WriteLine("  ");
        }
        //using Recursion
        public void PrintFibonacciNum(int firstNumber,int secondNumber,int counter,int length)
        {
            if (counter < length)
            {
                Console.Write("{0} ", firstNumber);
                PrintFibonacciNum(secondNumber,firstNumber+secondNumber,counter+1,length);
            }
            Console.WriteLine("");
        }
    }
}
