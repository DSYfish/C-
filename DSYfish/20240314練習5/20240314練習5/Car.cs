using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240314練習5
{
    internal class Car
    {
        string color = "red";
        int maxSpeed = 200;
        static int totalCar = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(totalCar);
            Car myCar = new Car();
            Console.WriteLine("車子顏色："+myCar.color);
            Console.WriteLine("車子的最高速："+myCar.maxSpeed);
            Console.ReadKey();
        }
    }
}
