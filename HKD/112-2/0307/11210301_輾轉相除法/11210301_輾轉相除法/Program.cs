using System;


namespace _11210301_輾轉相除法
{
    internal class Program
    {
        static int f(int n, int m)
        {
            if (m == 0) return n;
            else return f(m, n%m);
        }
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            int max = int.Parse(n[0]);
            int min;
            if (max < int.Parse(n[1]))
            {
                min = max;
                max = int.Parse(n[1]);
            }
            else
            {
                min = int.Parse(n[1]);
            }
            Console.WriteLine(f(max, min));
           
            Console.ReadKey();
        }
    }
}
