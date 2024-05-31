using System;

namespace 尋找陣列之中的特定數字
{
    internal class Program
    {
        static string Read()
        {
            return Console.ReadLine();
        }
        static void Write(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };
            int s = 0, e = array.Length - 1;
            int n = int.Parse(Read());
            while (s <= e)
            {
                int m = s + (e - s) / 2;
                if (array[m] < n) s = ++m;
                else if (array[m] > n) e = --m;
                else
                {
                    e = -1;
                    Write($"{m}:{array[m]}");
                    break;
                }
            }
            if(e != -1) Write("沒找到" + n);
            Console.ReadKey();
        }
    }
}
