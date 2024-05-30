using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20231120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int n = int.Parse(num[0]);
            int k = int.Parse(num[1]);
            string tmp = n.ToString();
            string test = k.ToString();
            while (true) 
            {
                if (n % k == 0)
                {
                    Console.WriteLine("YES");
                    break;
                }
                else if (tmp.Contains($"{test}")) 
                {
                    Console.WriteLine("YES");
                    break;
                }
                else 
                {
                    Console.WriteLine("NO");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}