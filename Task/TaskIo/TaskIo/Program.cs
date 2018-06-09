using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> task = Task.Factory.StartNew<string>
                (() => GetPosts("https://jsonplaceholder.typicode.com/posts"));
            task.Wait();

             SomethingElse();
            try
            {
               Console.WriteLine(task.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private static void SomethingElse()
        {
            // Dummy Method...........
        }

        private static string GetPosts(string url)
        {
            using (var client = new System.Net.WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}
