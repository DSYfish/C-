using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240229方式3
{
    internal class Program
    {
        static double BMI(int height,int weight)
        {
            double h = (double) height /100;
            return(weight / (h * h));
        }
        static void Main(string[] args)
        {
            Console.Write("請輸入你的身高(cm)：");
            int height = int.Parse(Console.ReadLine());
            Console.Write("請輸入你的體重(kg)：");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("你的BMI是：");
            Console.WriteLine(BMI(height,weight));
            Console.ReadKey();
        }
    }
}
