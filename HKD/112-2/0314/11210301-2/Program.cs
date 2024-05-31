using System;

namespace _11210301_2
{
    internal class Program
    {
        static void cbv(int n, int m)
        {
            n += 2;
            m += 3;
        }
        static void cbR(ref int n, ref int m)
        {
            n += 2;
            m += 3;
        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            cbv(n, m);
            Console.WriteLine($"n={n},m={m}");
            cbR(ref n, ref m);
            Console.WriteLine($"n={n},m={m}");
            Console.ReadKey();
        }
    }
}
