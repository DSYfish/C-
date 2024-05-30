using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240222阿姆斯壯數
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數：");
            string data =Console.ReadLine();
            int len = data.Length;
            int sum = 0;
            for(int i = 0; i < len; i++)
            {
                sum +=(int) Math.Pow(int.Parse(data[i].ToString()),len);
            }
            if(sum.ToString() == data)
            {
                Console.WriteLine($"{sum}是一個阿姆斯壯數");
            }
            else
            {
                Console.WriteLine($"{sum}不是一個阿姆斯壯數");
            }
            //Console.WriteLine(sum);



            Console.ReadKey();
        }
    }
}
