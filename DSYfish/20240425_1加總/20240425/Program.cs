using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240425_1
{
    internal class Program
    {
        static int summation(int[] array)//加總
        {
            int n = 0;
            foreach(int item in array)
            {n += item;}
            return n;
        }
        static int sumpositive(int[] array)
        {
            int n = 0;
            foreach(int item in array) { if(item > 0) n += item;}
            return n;
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 6, 9, -8, 1 };
            Console.WriteLine(summation(array));
            Console.WriteLine(sumpositive(array));
            Console.ReadLine();
        }
    }
}
