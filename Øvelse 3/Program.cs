using System;
using System.Threading;

namespace Øvelse_3
{
    class Program
    {
        static void Main(string[] args)
        {
            temperature temperature = new temperature();
            Thread t = new Thread(temperature.temperatureChecks);//creates thread with method temperaturechecks
            t.Start();//starts thread
            while (t.IsAlive)//is in while loop waiting for t to go false then leaving while loop
            {
                Thread.Sleep(10000);// threads sleep for 10000ms or 10 sec
            }
            Console.WriteLine("Alarm Tråd Termineret");//writes that thread is terminatet
        }
    }
}
