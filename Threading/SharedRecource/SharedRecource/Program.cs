using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharedRecource
{
    class Program
    {
        public static bool IsCopmpleted;
        static void Main(string[] args)
        {
            // worker thred..............
            Thread thread= new Thread(HelloWorld);
            thread.Start();

            // Main Thread..........
            HelloWorld();
        }

        private static void HelloWorld()
        {
            if (!IsCopmpleted)
            {
                Console.WriteLine("Hello world print one time.");
                IsCopmpleted = true;
            }
         
        }

       
    }
}
