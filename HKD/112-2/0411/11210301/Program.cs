using System;


namespace _11210301
{
    internal class Program
    {
        static int lu(int x)
        {
            if (x == 0) return 2;
            else if (x == 1) return 1;
            else return lu(x-1) + lu(x-2);
        }
        static void Main(string[] args)
        {
            Console.Write("輸入整數：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(lu(n));
            Console.ReadKey();
        }
    }
}
