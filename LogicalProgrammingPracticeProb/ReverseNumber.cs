using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class ReverseNumber
    {
        public void PrintReverseofNum(int n)
        {
            int reverse = 0;
            while (n > 0)//n=123 12 1 0
            {
                int rem = n % 10;//3 2 1
                reverse = (reverse * 10) + rem;//3 32 321
                n /= 10;//12 1 
            }
                Console.WriteLine("Reverse of Number :" + reverse);//321
        }
    }
}
