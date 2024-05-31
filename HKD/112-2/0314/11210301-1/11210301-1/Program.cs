using System;

namespace _11210301_1
{
    internal class Program
    {

        static int gcd(int n, int m)
        {
            if (m == 0) return n;
            return gcd(m, n % m);
        }
        static void Main(string[] args)
        {
            Console.Write("輸入兩數(空格隔開)：");
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            Console.WriteLine(gcd(n, m));
            Console.ReadKey();
        }
    }
}
