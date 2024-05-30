using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =Convert.ToInt32(Console.ReadLine());
            while (n > 0) 
            {
                string[] ans1 = Console.ReadLine().Split(' ');
                char m =Convert.ToChar(ans1[0]);
                int a = Convert.ToInt32(ans1[1]);
                int b = Convert.ToInt32(ans1[2]);
                int c = Convert.ToInt32(ans1[3]);
                int d = Convert.ToInt32(ans1[4]);
                
                if (m == '+')
                {
                    Console.WriteLine((a + b)+" "+(c + d));
                }
                else if (m == '-')
                {
                    Console.WriteLine((a-b)+" "+(c-d));
                }
                else if (m == '*')
                {
                    Console.WriteLine((a*b)+" "+(c*d));
                }
                else
                {
                    Console.WriteLine((a/b)+" "+(c/d));
                }
                Console.ReadKey();
            }
        }
    }
}
