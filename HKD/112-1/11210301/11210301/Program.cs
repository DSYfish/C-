using System;
using System.Diagnostics;

namespace _11210301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, all = 0, sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i;
                for (int j = 2; j < i ; j++)
                {
                    if (i % j == 0)
                    {
                        all += i;
                        break;
                    }
                }
            }
            sum -= all;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
