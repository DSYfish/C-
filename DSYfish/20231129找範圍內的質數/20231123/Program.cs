using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] ans = Console.ReadLine().Split();
                bool prime = true;
                int start = int.Parse(ans[0]);
                int end = int.Parse(ans[1]);
                int tmp = 0;
                if (start == 0 && end == 0) break;
                for (int i = start; i < end; i++)
                {
                    prime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }   
    }
}
