using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_1
{
    class ProcessesForThreads
    {
        public void process(object text)//receives object
        {
            for (int i = 0; i < 5; i++)//writes 5 times
            {
                Console.WriteLine(text as string);//writes text object with string
            }
        }
    }
}
