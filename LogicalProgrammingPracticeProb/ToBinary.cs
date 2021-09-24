using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class ToBinary
    {
        public string CalToBinary(int decimalNum)//14
        {
            int[] binary = new int[8];
            int i;
            string bin = "";
            string binaryex = Convert.ToString(decimalNum, 2).PadLeft(8, '0');//in only single line decimal-to-binary conversion
            Console.WriteLine("binaryvalue:" + binaryex);
            Console.Write("Decimal Number :" + decimalNum + " to binary Number: " + " ");
            for (i = 0; decimalNum > 0; i++)
            {
                binary[i] = decimalNum % 2;//0 1 1 1
                decimalNum /= 2;//7
            }
            //string[] strArr = Array.ConvertAll(binary, e => e.ToString());
            //Array.Resize(ref strArr, 4);//1 1 1 0
            //Array.Reverse(strArr);
            //x = string.Join("", strArr);
            ////Console.WriteLine(x);
            //int y = Int16.Parse(x);
            //Console.Write(y);
            for (i -= 1; i >= 0; i--)
            {
                //Console.Write(binary[i]);
                bin = string.Concat(binary);
                bin = string.Join("", binary);
            }
            Console.WriteLine(" binary string:" + bin);
            Console.WriteLine("");
            return bin;
        }

    }
}