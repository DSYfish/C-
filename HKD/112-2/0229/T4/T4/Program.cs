using System;

namespace T4
{
    internal class Program
    {
        static double area(double wide)
        {
            return wide * wide;
        }
        static double area(double wide, double height)
        {
            return height * wide;
        }
        static double area(double wide1, double wide2, double height)
        {
            return (wide1+wide2)*height/2;
        }
        static void Main(string[] args)
        {
            double w1 = 4.5, w2 = 3.2, h = 1.5;
            Console.WriteLine("長：" + w1);
            Console.WriteLine("正方形：" + area(w1));
            Console.WriteLine($"\n長：{w1}　寬：{w2}");
            Console.WriteLine("長方形：" + area(w1, w2));
            Console.WriteLine($"\n上底：{w1}　下底：{w2}　高：{h}");
            Console.WriteLine("梯形：" + area(w1,w2,h));
            Console.ReadKey();

        }
    }
}
