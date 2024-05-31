using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240110第二題
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串整數(空白分隔)：");
            string[] str = Console.ReadLine().Split(' ');
            int one = 0;
            int two = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (int.Parse(str[i]) % 2 == 0)
                    two += int.Parse(str[i]);
                else
                    one += int.Parse(str[i]);
            }
            Console.WriteLine(two + " - " + one + " = " + (two - one));
            Console.ReadLine();
        }
    }
}
