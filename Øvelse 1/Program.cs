using System;
using System.Threading;

namespace Øvelse_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessesForThreads pt = new ProcessesForThreads();
            Thread t1 = new Thread(pt.process);//Creates thread 1
            Thread t2 = new Thread(pt.process);//Creates thread 2
            t1.Start("C#-trådning er nemt!");//starts thread 1 with statement "C#-trådning er nemt!"
            t2.Start("Også med flere tråde…");//starts thread 1 with statement "Også med flere tråde…"
            t1.Join();
            t2.Join();
            Console.ReadKey();
        }
    }
}
