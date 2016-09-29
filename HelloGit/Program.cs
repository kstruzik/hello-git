using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git!");

            double number = 3.5670;
            double precision = 2;
            string display = string.Format("{0:f" + precision + "}", number);
            Console.WriteLine(display);

            Console.ReadKey();
        }
    }
}
