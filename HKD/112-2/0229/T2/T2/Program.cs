using System;

namespace T2
{
    internal class Program
    {
        static double BMI(double h, double w)
        {
            h /= (double)100;
            h *= (double)h;
            return (double) (w / h);
        }
        static double IBW(int sex, int h)
        {
            return (sex == 0) ? (double)(h - 70) * 0.6 : (double)(h - 80) * 0.7;
        }
        static void Main(string[] args)
        {
            Console.Write("請輸入性別(0:女 1:男)：");
            int sex = int.Parse(Console.ReadLine());
            Console.Write("請輸入身高(cm)：");
            int h = int.Parse(Console.ReadLine());
            Console.Write("請輸入體重(kg)：");
            int w = int.Parse(Console.ReadLine());
            double I = IBW(sex, h);
            Console.WriteLine("\n結果如下：");
            Console.WriteLine("你的BMI值為：" + BMI(h, w).ToString("f2"));
            if (w >= I * 0.9 && w <= I * 1.1)
            {
                Console.WriteLine("標準範圍內");
            }
            else if (w < I * 0.9)
            {
                Console.WriteLine("體重過輕！");
            }
            else if (w > I * 1.1)
            {
                Console.WriteLine("體重過重！");
                if(w >= I * 1.2)
                {
                    Console.WriteLine($"體重已嚴重超標：{((w-I)/I*100).ToString("f2")}%！");
                }
            }


            Console.WriteLine("\n\n標準體重如下：");
            Console.WriteLine($"過輕範圍：{I * 0.8}～{I * 0.9}");
            Console.WriteLine($"標準範圍：{I * 0.9}～{I * 1.1}");
            Console.WriteLine($"過重範圍：{I * 1.1}～{I * 1.2}");
            Console.WriteLine($"超重範圍：{I * 1.2}↑");
            Console.ReadKey();

        }
    }
}
