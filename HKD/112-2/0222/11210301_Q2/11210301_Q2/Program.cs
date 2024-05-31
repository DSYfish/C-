using System;

namespace _11210301_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串整數(空白分隔)：");
            string[] num = Console.ReadLine().Split(' ');
            int odd = 0;
            int even = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num[i]) % 2 == 0)
                {
                    odd += int.Parse(num[i].ToString());
                }
                else
                {
                    even += int.Parse(num[i].ToString());
                }
            }
            Console.WriteLine($"{odd} - {even} = {odd-even}");
            Console.ReadKey();
        }
    }
}
