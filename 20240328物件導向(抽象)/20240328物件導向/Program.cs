using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240328物件導向
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Pig:Animal 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee"); //豬繼承叫聲
        }
    }
    interface IAnimal2 //加一個I表示interface ：自動加Public、不用加override(覆蓋)、繼承要Public，預先定義好
    {
        void animalSound();
        void sleep();
    }
    class Pig2 : IAnimal2 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
        public void sleep()
        {
            Console.WriteLine("Zzzzzzzzz");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig myObj = new Pig();
            myObj.animalSound();
            myObj.sleep();
            
            Pig2 myObj2 = new Pig2();
            myObj2.animalSound();
            myObj2.sleep();

            Console.ReadKey();
        }
    }
}
