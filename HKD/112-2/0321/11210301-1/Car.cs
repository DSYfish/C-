using System;


namespace _11210301_1
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
        public Car(string modelname)
        {
            this.model = modelname;
        }
        public Car(string model, string color, int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
            Car Nissan = new Car("Cherry");
            Console.WriteLine(Nissan.model);
            Car Tank = new Car("T-34/85","gray", 1940);
            Console.WriteLine(Tank.model);

            Console.ReadKey();
        }
    }
}
