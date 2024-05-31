using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240229方法1
{
    internal class Program
    {
        static void method() 
        {
            Console.WriteLine("歡迎光臨");
        }
        
        static void method2(string fname)
        {
            Console.WriteLine($"{fname}您好，歡迎光臨");
        }
        static void method3(string fname,int age)
        {
            Console.WriteLine($"{fname}是{age}歲");
        }
        static void method4(string fname="喜洋洋") 
        {
            Console.WriteLine(fname + "您好，歡迎光臨");
        }

        static void Main(string[] args)
        {
            Console.Write("請選擇:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    method();
                    break;
                case 2:
                    method();
                    method();
                    method();
                    break;
                case 3:
                    method2("張三");
                    break; 
                case 4:
                    method3("李四",20);
                    break;
                case 5:
                    method4();
                    break;
            }
            Console.ReadLine();
        }
    }
}
