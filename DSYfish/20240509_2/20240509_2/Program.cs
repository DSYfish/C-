using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240509_2
{
    internal class Program
    {
        static int find_mininum(int[] array)
        {
            int min = array[0];
            foreach (int i in array)
            {
                if (i < min)min = i;
            }
            return min;
        }
        static void find_all_number(int[] array,int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    Console.WriteLine(i + ":" + array[i]);
                    break;
                }
            }
        }
        static bool find_number(int[,] array, int n)
        {
            foreach(int item in array) 
            {
                if (item == n)return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 6, 9, -8, 1 };
            int n = 6;
            Console.WriteLine("最小值："+find_mininum(array));
            find_all_number(array, n);
            int[,] array2 = { { 3, 6, 9, -8, 1 }, { 2, 4, 6, 8, 10 },{ 11, 7, 5, 3, 2 } };
            find_number(array2,6);
            if (find_number(array2, 6)) 
                Console.WriteLine("有找到");
            else 
                Console.WriteLine("沒找到");
            Console.ReadLine();
        }
    }
}
