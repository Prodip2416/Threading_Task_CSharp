using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread= new Thread(PrintHelloWorld);
            thread.Start();
            thread.Join();
            Console.WriteLine("Print Hello World");
            Console.ReadKey();
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
            Thread.Sleep(5000);
        }
    }
}
