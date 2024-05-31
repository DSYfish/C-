using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240110第一題
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("輸入一個正整數：");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(n + "是一個完美數。");

            }
            else
            {
                Console.WriteLine(n+ "不是一個完美數");
            }
            Console.ReadLine();
        }
    }
}
