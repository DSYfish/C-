using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240323物件導向3
{
    class Vehicle
    { 
        public string brand = "Ford"; public virtual void honk()
        {Console.WriteLine("逼逼");}
    }
    class Car : Vehicle
        {
            public string modelName = "mustang";
        public string brand = "Toyota";
            public override void honk()
        {
            Console.WriteLine("叭叭");
        }
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.honk();

            Console.Write("brand=" + mycar.brand,"model"+mycar.modelName);

            Console.ReadLine();
        }
    }
}
