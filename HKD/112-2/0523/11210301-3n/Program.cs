using System;


namespace _11210301_3n
{
    internal class Program
    {
        static int c3N_1(int n)
        {
            int count = 0;
            while (n != 1)
            {
                if (n % 2 == 1)
                {
                    n = 3 * n +1;
                }
                else
                {
                    n = n / 2;
                }
                count++;
            }
            count++;
            return count;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                int m = int.Parse(s[0]);
                int n = int.Parse(s[1]);
                int maxcount = 0;
                for (int i = m; i <= n; i++)
                {
                    maxcount = Math.Max(maxcount, c3N_1(i));
                }
                Console.WriteLine($"{m} {n} {maxcount}");
            }
        }
    }
}
