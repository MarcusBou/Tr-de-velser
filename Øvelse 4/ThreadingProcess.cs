using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Øvelse_4
{
    class ThreadingProcess
    {
        private char printingChar = '*';

        public void printer()
        {
            while (true)
            {
                Console.Write(printingChar);//prints printingchar
                Thread.Sleep(30);
            }
        }

        public void reader()
        {
            while (true)
            {
                string result = Console.ReadLine();//line user wrote as string
                if (result != "")//make sure string isnt empty
                {
                    printingChar = result[result.Length - 1];//sets last char in string as result
                }
            }
        }
    }
}
