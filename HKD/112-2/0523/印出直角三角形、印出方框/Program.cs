using System;

namespace 印出直角三角形_印出方框
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("　");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n - 1 || i == 0 || j == 0 || j == n - 1) { 
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("　");
                    }
                    else
                    {
                        Console.Write("　");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
