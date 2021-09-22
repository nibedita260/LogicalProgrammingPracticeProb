using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class VendingMachine
    {
        public void MinNumberOfNote(int change)
        {
            int[] arr = {1000,500,100,50,10,5,2,1};
            int largest = arr[0];
            int count = 0;
            Console.WriteLine("input is " + change);
            for (int i = 0; i < arr.Length; i++)
            {
                if (change == arr[0])
                {
                    Console.Write("largest value of the Note to return change to get to minimum" + count + " number of Notes" + largest);
                    //MinNumberOfNote(largest);
                    break;
                }
                for (int j = i + 1; j < i; j++)
                {
                    if (arr[j]+arr[i]==change)
                    {
                        largest = arr[j] + arr[i];
                        count++;
                        Console.Write("value of the Note to return change to get to minimum" + count + " number of Notes" + largest);
                    }
                }
            }
            Console.Write("value of the Note to return change to get to minimum "+ count+" number of Notes :" + largest);
            Console.WriteLine(" ");
        }
    }
}
