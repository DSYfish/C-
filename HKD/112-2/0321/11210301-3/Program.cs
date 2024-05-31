using System;

namespace _11210301_3
{
    class Vehicle
    {
        public string brand = "Ford";
        public virtual void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehicle
    {
        public string modelname = "Mustang";
        public new string brand = "Toyota";
        public override void honk()
        {
            Console.WriteLine("巴巴");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.honk();
            Console.WriteLine($"{mycar.brand} {mycar.modelname}");
            Console.ReadKey();
        }
    }
}
