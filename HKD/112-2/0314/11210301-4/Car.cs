using System;


namespace _11210301_4
{
    internal class Car
    {
        string color = "red";
        int maxSpeed = 200;
        static int totalCar = 0;
        Car()
        {
            totalCar++;
        }
        static void Main(string[] args)
        {
            Car mycar = new Car();
            Car mycar1 = new Car();
            Console.WriteLine(Car.totalCar);
            Console.WriteLine($"車子顏色：{mycar.color}");
            Console.WriteLine($"車子速度：{mycar.maxSpeed}");
            Console.ReadKey();
        }
    }
}
