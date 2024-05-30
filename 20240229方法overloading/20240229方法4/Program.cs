using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240229方法4
{
    internal class Program
    {
        //overloading
        static double area(double wide) 
        {
            return wide * wide;
        }
        static double area(double wide,double height) 
        {
            return (wide * height)/2;
        }
        static double area(double down, double up, double height)
        {
            return (up + down) * height / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("正方形面積:"+area(10));
            Console.WriteLine("長方形面積:" + area(10, 5));
            Console.WriteLine("梯形面積:" + area(10, 5, 50));
            Console.ReadLine();
        }
    }
}
