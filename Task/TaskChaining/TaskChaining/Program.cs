using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> antecedent= Task.Run(() =>
            {
                Task.Delay(3000);
                return DateTime.Now.ToShortDateString();
            });
            Task<string> continuetion = antecedent.ContinueWith(x => "Today is " + antecedent.Result);

            Console.WriteLine(continuetion.Result);
        }
    }
}
