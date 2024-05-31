using System;

namespace 印出直角三角形
{
    internal class Program
    {
        static void print_S(int num, char s )
        {

            for (int j = 0; j < num; j++)Console.Write(s);
        }
        static void Main(string[] args)
        {
            int h = 5;
            for (int i = 0; i < h; i++)
            {
                print_S(h - i, '#');
                print_S(i * 2, ' ');
                print_S(h - i , '#');
                Console.WriteLine();
            }
            for (int i = h-1; i >= 0; i--)
            {
                print_S(h - i, '#');
                print_S(i * 2, ' ');
                print_S(h - i, '#');
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
