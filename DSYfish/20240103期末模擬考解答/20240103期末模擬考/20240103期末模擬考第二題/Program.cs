using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240103期末模擬考第二題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一序列整數(以空白區隔)：");
            string[] data = Console.ReadLine().Split(' ');
            int pass = 0;
            int failed = 0;
            for(int i = 0; i < data.Length; i++)
            {
                int value = int.Parse(data[i]);
                if (value >= 60) pass++;
                else failed++;
            }
            Console.WriteLine("及格有：" + pass + "人");
            Console.WriteLine("不及格有:" + failed + "人");
            Console.ReadKey();
        }
    }
}
