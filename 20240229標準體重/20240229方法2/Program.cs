using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240229方法2
{
    internal class Program
    {
        static double start(int gendar, int hight)
        {
            if (gendar == 0)
                return (hight - 70) * 0.6;
            else
                return (hight - 80) * 0.7;
            
        }
        static void Main(string[] args)
        {
            Console.Write("請輸入性別(0:女、1:男):");
            int gender = int.Parse(Console.ReadLine());
            Console.Write("請輸入身高(cm):");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("標準體重"+start(gender, height));
            Console.ReadLine();
        }
    }
}
