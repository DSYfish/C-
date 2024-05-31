using System;

namespace 十分逼近法
{
    internal class Program
    {
        static double sqrt_coustom(int n, int times = 4)
        {
            double p = 0;
            for (int i = 0; i <= times; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    double t1 = p + 1.0 / Math.Pow(10, i) * j;
                    double t2 = p + 1.0 / Math.Pow(10, i) * (j+1);
                    if (t1 * t1 <= n && t2 * t2 > n)
                    {
                        p = t1;
                        break;
                    }
                }
            }
            return p;
        }
        static string input(string s)
        {
            Console.Write(s);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string[] n = input("求需根號數 後幾位：(需空白)").Split(' ');
            Console.WriteLine(sqrt_coustom(int.Parse(n[0]), int.Parse(n[1])).ToString());
            Console.ReadKey();
        }
    }
}
