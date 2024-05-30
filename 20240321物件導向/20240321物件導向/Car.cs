using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240321物件導向
{
    internal class Car
    {
        public string model; 
        public string color;
        public int year;
        public Car()
        {
            model = "Mustang";
        }        
        public Car(string model)
        {
            this.model = model;
        }
        public Car(string model, string color , int year)
        {
            this.model= model;
            this.color = color;
            this.year = year;   
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
            Car BMW = new Car("BMW-1");
            Console.WriteLine(BMW.model);
            Car Toyota = new Car("Camery", "藍色", 2024);
            Console.WriteLine(Toyota.model);
            Console.ReadKey();
        }
    }
}
