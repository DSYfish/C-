using System;

namespace T1
    //程式碼範圍
{
    internal class Program
        //物件
    {
        static void method1()
        {
            Console.WriteLine("Welcome");
        }
        static void method2(string name)
        {
            Console.WriteLine($"{name} Welcome");
        }
        static void method3(string name, int age)
        {
            Console.WriteLine($"{name} 是 {age} 歲");
        }
        static void method4(string name = "Puppy")
        {
            Console.WriteLine($"Hello! {name}");
        }
        static void Main(string[] args)
            //方法
        {
            Console.Write("輸入一個數值：");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    method1(); 
                    break;
                case 2:
                    method1();
                    method1();
                    method1();
                    break;
                case 3:
                    method2("小明");
                    break;
                case 4:
                    method3("小傘",18);
                    break;
                case 5:
                    method4("ABD");
                    method4();
                    break;
            }

            Console.ReadKey();
        }
    }
}
