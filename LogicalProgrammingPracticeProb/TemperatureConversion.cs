using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgrammingPracticeProb
{
    class TemperatureConversion
    {
        public void CalTemp(float temp,string tempCheck)
        {
            Console.WriteLine("Please pass the second parameter temperatues in 'farahenite' or 'celcius'");
            Console.WriteLine("the temperature you given in:" + tempCheck);
            switch (tempCheck)
            {
                case "farahenite": float celcius = (temp - 32) * 5 / 9;
                    Console.WriteLine("The temperatue conversion farahenite to celcius is:" + celcius+"C");
                    break;
                case "celcius":float  farahenite = (temp * 9 / 5) + 32;
                    Console.WriteLine("The temperatue conversion celcius to farahenite is:" + farahenite+"F");
                    break;
                default:
                    Console.WriteLine("enter a valid temperatue");
                    break;
            }
        }
    }
}
