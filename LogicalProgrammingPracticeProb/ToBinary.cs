using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class ToBinary
    {
        public int CalToBinary(int decimalNum)//14
        {
            int[] binary = new int[decimalNum];
            int i,y;
            string x;
            Console.Write("Decimal Number :" + decimalNum + " to binary Number: " + " ");
            for (i = 0; decimalNum > 0; i++)
            {
                    binary[i] = decimalNum % 2;//0 1 1 1
                    decimalNum /= 2;//7
            }
            string[] strArr = Array.ConvertAll(binary, e => e.ToString());
            Array.Resize(ref strArr, 4);//1 1 1 0
            Array.Reverse(strArr);
            x = string.Join("", strArr);
            //Console.WriteLine(x);
            y = Int16.Parse(x);
            Console.Write(y);
            Console.WriteLine("");
            return y;
        } 
    }
}
