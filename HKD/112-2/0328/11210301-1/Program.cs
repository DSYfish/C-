using System;

namespace _11210301_1
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }

    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pig says: Wee wee wee");
        }
    }
    interface IAnimal2
    {
        void animalSound();
        void sleep();
    }
    class Pig2 : IAnimal2
    {
        public void animalSound()
        {
            Console.WriteLine("The Pig says: Weeeeeeeeeeeeeeee weeeeeeeeeeeee weeeeeeeeeeeee");
        }
        public void sleep()
        {
            Console.WriteLine("Zeeeeeeeeeeeezzzzzzzzzzzz");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig myobj = new Pig();
            myobj.animalSound();

            Pig2 pig2 = new Pig2();
            pig2.animalSound();
            Console.ReadKey();
        }
    }
}
