using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContextSwitching
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread= new Thread(StartWorkerThread);
            thread.Start();


            //Main Thread..........
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" A" + i + " ");
            }
        }

        private static void StartWorkerThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" Z"+i+" ");
            }
        }
    }
}
