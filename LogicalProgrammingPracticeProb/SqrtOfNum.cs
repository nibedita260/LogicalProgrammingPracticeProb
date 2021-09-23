using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class SqrtOfNum
    {
        public void CalSqrtOfNum(double c)
        {
            double t = c;
            //epsilon = 1e-15;
            double sqrtNum;
            double l = 0.00001;
            int count = 0;
            while (true)
            {
                count++;
                sqrtNum = 0.5 * (t + (c / t));
                if (Math.Abs(sqrtNum - t) < l)
                    break;
                t = sqrtNum;
            }
            Console.WriteLine("Square root of given number is:" + sqrtNum);
        }
    }
}
