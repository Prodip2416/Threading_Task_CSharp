using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(PrintHelloWorld);
            task.Start();

            Task<string> returnThatString=new Task<string>(Helo);
            returnThatString.Start();
            returnThatString.Wait();
            Console.WriteLine(returnThatString.Result);
            
        }

        private static string Helo()
        {
            Thread.Sleep(3000);
            return "Hello";
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
