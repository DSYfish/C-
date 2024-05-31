using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._10._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0;
            for (int i = 1; i < x; i++)
            
            {
                sum1+= i;
            }
            Console.WriteLine(sum1);
            Console.ReadKey();
            
        }
    }
}
