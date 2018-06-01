using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
        }

        private static void Demo()
        {
          new Thread(Exception).Start();
        }

        private static void Exception()
        {
            try
            {
                throw null;
            }
            catch
            {
                
            }
           
        }
    }
}
