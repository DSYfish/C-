using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11210360
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year =Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("閏年");
            }
            else
            {
                Console.WriteLine("平年");
            }
            Console.ReadLine();
        }
    }
}
