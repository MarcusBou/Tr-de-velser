using System;
using System.Threading;

namespace Øvelse_0
{
    class program
    {
        public void WorkThreadFunction(object obj)
        {
            for (int i = 0; i< 5; i++)//runs 5 times
            {
                Console.WriteLine(obj + " Thinks threading is simple");//writes out text
            }
        }
    }

    class threprog
    {
        static void Main(string[] args)
        {
            program pg = new program();
            Thread t1 = new Thread(pg.WorkThreadFunction);//creates threads with the workthreadfunction
            Thread t2 = new Thread(pg.WorkThreadFunction);//creates threads with the workthreadfunction
            Thread t3 = new Thread(pg.WorkThreadFunction);//creates threads with the workthreadfunction
            t1.Name = "Kirsten";//gives t1 a name
            t2.Name = "Henrik";//gives t2 a name
            t3.Name = "Jytte";//gives t3 a name
            t1.Start(t1.Name);//Executes thread with given name
            t2.Start(t2.Name);//Executes thread with given name
            t3.Start(t3.Name);//Executes thread with given name
            t1.Join();
            t2.Join();
            t3.Join();
            Console.Read();
        }
    }
}
