using System;

namespace _11210301_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string num;
            Console.Write("請輸入一整數： ");
            num = Console.ReadLine();
            for (int i = 0; i < num.Length; i++) 
            {
                sum += M_Pow(int.Parse(num[i].ToString()), num.Length);
            }
            Console.WriteLine((int.Parse(num) == sum) ? $"{num} 是一個阿姆斯壯數" : $"{num} 不是個阿姆斯壯數");
            Console.ReadKey();
        }
        static int M_Pow(int x, int time, int sum = 1)
        {
            sum = sum * x;
            if (--time == 0) return sum;
            return M_Pow(x, time, sum);
        }
    }
}
