using System;

namespace 對調數字
{
    internal class Program
    {
        static void swap_int(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 3;
            Console.WriteLine($"n1={num1},n2={num2}");
            swap_int(ref num1, ref num2);
            Console.WriteLine("轉換後");
            Console.WriteLine($"n1={num1},n2={num2}");
            Console.ReadKey();
        }
    }
}
