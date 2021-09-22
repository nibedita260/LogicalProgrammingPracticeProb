using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class PerfectNumber
    {
        public void CheckPerfectNum(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)//n=28
            {
                if (n % i == 0)
                {
                    sum += i;//1+2+4+7+14=28 28 is a perfectnumber,1+3+9 !=27 27 is not a perfect number
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Given number is perfect number");
            }
            else
            {
                Console.WriteLine("Given number is not a perfect number");
            }
        }
    }
}
