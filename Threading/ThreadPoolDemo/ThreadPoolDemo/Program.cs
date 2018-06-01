using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

            Employee employee=new Employee();
            employee.Name = "Prodip";
            employee.CompanyName = "RoobNet";
            ThreadPool.QueueUserWorkItem(new WaitCallback(DisplayEmployeeInfo),employee);

            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

            Console.ReadKey();
        }
        private static void DisplayEmployeeInfo(object employee)
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Employee emp= employee as Employee;
            Console.WriteLine("Employee Name is = {0} and company name is = {1}",emp.Name,emp.CompanyName);
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string CompanyName { get; set; } 
    }
}
