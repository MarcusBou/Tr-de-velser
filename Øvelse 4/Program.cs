using System;
using System.Threading;

namespace Øvelse_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadingProcess tp = new ThreadingProcess();
            Thread t1 = new Thread(tp.printer);
            Thread t2 = new Thread(tp.reader);
            t1.Start();//thread start
            t2.Start();//thread start
            t1.Join();
            t2.Join();
        }
    }
}
