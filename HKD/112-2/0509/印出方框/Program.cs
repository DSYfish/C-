using System;

namespace 印出方框
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 5;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write('＠');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for(int j = 1;j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)Console.Write('＠');
                    else Console.Write('　');
                }
                    Console.WriteLine();
            }
            Console.WriteLine();

            char[,] screen = new char[n, n];
            for (int i = 0; i < n; i++) for (int j = 0; j < n; j++) screen[i, j] = '　';
            char s = '＠';
            for (int i = 0; i < n; i++)
            {
                screen[0,i] = s;
                screen[n-1, i] = s;
                screen[i,0] = s;
                screen[i, n-1] = s;
            }
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(screen[i,j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
