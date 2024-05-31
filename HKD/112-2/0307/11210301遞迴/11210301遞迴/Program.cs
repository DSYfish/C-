using System;

namespace _11210301遞迴
{
    internal class Program
    {
        static int f(int n)
        {
            if (n == 1) return n;
            else return n * f(n - 1);
        }
        static int f2(int n ,int m)
        {
            if (m == 1) return n;
            else return f2(n, m - 1) + n;
        }
        static int f3(int n, int m)
        {
            if (m == 0) return 1;
            else if (m == 1) return n;
            else return f3(n, m - 1) * n;
        
        }
        static void Main()
        {
            int n;
            Console.Write("第幾題(1~3)：");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Write("請輸入一整數：");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{n} 的階層為{f(n)}");
                    break;
                case 2:
                    Console.Write("請輸入二整數(空格隔開)：");
                    string[] m = Console.ReadLine().Split();
                    Console.WriteLine($"{m[0]}*{m[1]} 為 {f2(int.Parse(m[0]), int.Parse(m[1]))}");
                    break;
                case 3:
                    Console.Write("請輸入二整數(空格隔開)：");
                    string[] str = Console.ReadLine().Split();
                    Console.WriteLine($"{str[0]}^{str[1]} 為 {f3(int.Parse(str[0]), int.Parse(str[1]))}");
                    break;
                default:
                    Console.WriteLine("未知的題目\n按任一鍵繼續...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
            }
            Console.ReadKey();
        }
    }
}
