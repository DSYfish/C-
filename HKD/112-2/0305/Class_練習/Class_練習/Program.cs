using System;

namespace Class_練習
{
    internal class CCircle
    {
        private int radius;         //半徑
        public string color;
        private double pi = 3.14;   //圓周率
        public CCircle()
        {
            this.radius = 1;
            this.color = "Red";
        }
        public CCircle(int radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double Area()
        {
            return (double)radius * radius * pi;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            CCircle C1 = new CCircle(1, "Blue");
            CCircle C2 = new CCircle(6, "Black");
            Console.WriteLine($"C1 Area: {C1.Area()}");
            Console.WriteLine($"C2 Area: {C2.Area()}");
            Console.ReadKey();
        }
    }
}
