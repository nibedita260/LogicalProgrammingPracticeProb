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
            int[] notes = new int[8];
            int count = 0;
            Console.WriteLine("input is " + change);
            for (int i = 0; i < arr.Length; i++)
            {
                while (change / arr[i] != 0)
                {
                    if (arr[i] == 1000 || arr[i] == 100 || arr[i] == 10)
                    {
                        notes[i]=change/arr[i];
                        change %= arr[i];
                    }
                    else
                    {
                        notes[i] = ++count;
                        change %= arr[i];
                    }
                }
                count = 0;
            }
            for(int i = 0; i < notes.Length; i++)
            {
                count += notes[i];
                Console.WriteLine("Number of Rs. " + arr[i] + " Number of Notes needed :" + notes[i]);
            }
            Console.WriteLine("total number of minimum notes needed to return change " + count );
            Console.WriteLine(" ");
        }
    }
}
