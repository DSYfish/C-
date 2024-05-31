using System;

namespace 加總數字
{
    internal class Program
    {
        static int summation(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr) sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 6, 9, -8, 1 };
            Console.WriteLine(summation(arr));
            Console.ReadKey();
        }
    }
}
