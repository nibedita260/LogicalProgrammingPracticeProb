using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class BinarySwapNibblesAndResultantNumber
    {
        public void PrintSwapNumAndResultantNum(int n)
        {   
            //get binary string value from ToBinary class
            string nibble=GetBinaryNumber(n);//5
            //1.->>>> Swap nibbles(8-bit binary number) and find a new number
            Console.WriteLine("The 8-Bit of binary number is:" + nibble);
            string nibble1 = nibble.Substring(0, 4);
            int nibbl1 = Int16.Parse(nibble1);//1010
            string nibble2 = nibble.Substring(nibble.Length-4);
            int nibbl2 = Int16.Parse(nibble2);//0
            Console.WriteLine("Before Swapping the two nibbles are:" + nibbl1+","+nibbl2);//1010,0
            nibbl1 +=  nibbl2;//1010
            nibbl2 +=  nibbl1;//1010
            nibbl1 -=  nibbl2;//0
            Console.WriteLine("After Swapping the two nibbles are:" + nibbl1 + "," + nibbl2);//0,1010
            string nibl1 = nibbl1.ToString();
            string nibl2 = nibbl2.ToString();
            string resultant = nibl1 + nibl2;
            int resultantNum = Int32.Parse(resultant);
            Console.WriteLine("The Resultant number :" + resultantNum);
            //2.->>>> Calculate decimal form of the Resultant Number
            int resultantBinary, decimalNum = 0, baseVal = 1, rem;
            resultantBinary = resultantNum;
            while (resultantNum > 0)//11110 1111 111.1
            {
                rem = resultantNum % 10;//1111 111.1 11.11
                decimalNum = decimalNum + rem * baseVal;//1111 1333.2 13377.64
                resultantNum /= 10;//1111 111.1 0
                baseVal *= 2;//2 4 
            }
            Console.Write("Binary Number: " + resultantBinary);
            Console.Write("\nDecimal Number: " + decimalNum);
            Console.WriteLine("  ");
        }
        private static string GetBinaryNumber(int n)
        {
            ToBinary toBinary = new ToBinary();
            string binaryNum=toBinary.CalToBinary(n);
            return binaryNum;
        }
    }
}
