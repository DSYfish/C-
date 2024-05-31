using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _20240229
{
    internal class Program
    {
        static void typing()
        {
            Console.Write("別人請吃飯");
        }
        static void typing2()
        {
            Console.WriteLine("請我吃飯");
        }
        static void typing3()
        {
            Console.WriteLine("請你吃飯");
        }
        static void method(string fname = "寶貝")
        {
            Console.WriteLine("真是一個叛逆小壞壞");
            Console.Write($"{fname}請我吃飯好不好?");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("數字1~3選一個");
            Console.Write("請選澤:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    typing();
                    break;
                case 2: 
                    for(int i = 0; i < 3; i++)
                    {
                    typing2();
                    }
                    Console.WriteLine("啊啊啊啊!!!!!");
                    break;
                case 3:
                    typing3();
                    break;
                case 4:
                    Console.WriteLine("請輸入你的名字");
                    string fname = Console.ReadLine();
                    method(fname);
                    break;
            }
            Console.ReadKey();
        }
    }
}
