using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class ToBinary
    {
        public void CalToBinary(int decimalNum)//14
        {
            int[] binary = new int[decimalNum];
            int i;
            Console.Write("Decimal Number :" + decimalNum + " to binary Number: " + " ");
            for (i = 0; decimalNum > 0; i++)
            {
                    binary[i] = decimalNum % 2;//0 1 1 1
                    decimalNum /= 2;//7
            }
            for(i -=1; i >=0; i--)
            {
                Console.Write(binary[i]);//1 1 1 0
            }
            Console.WriteLine(" ");
        } 
    }
}
