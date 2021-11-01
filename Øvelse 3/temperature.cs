using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Øvelse_3
{
    class temperature
    {
        private int tempChances = 0;
        private int temp;
        public void temperatureChecks()
        {
            Random rnd = new Random();//create random object
            while (tempChances < 3)
            {
                temp = rnd.Next(-20, 121);//assign random numb for temp
                Console.WriteLine("temperature is: " + temp);//writes out temperatutere
                if (temp >= 100 || temp <= 0)//check if temp is in the legal range if it is outside of the legal range then tempchances++
                {
                    Console.WriteLine("Temperaturen er uden for Den tilladte temperatur");
                    tempChances++;
                }
                Thread.Sleep(2000);//threadSleeps
            }
        }
    }
}
