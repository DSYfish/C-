using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240530_1
{
    internal class Program
    {
        static void  printArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
        }
        static void insertSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int target = i;
                for(int j = i-1; j >=0; j--)
                    { 
                    if (array[target] < array[j])
                    {
                        int tmp = array[target];
                        array[target] = array[j];
                        array[j] = tmp;
                        target = j;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 8, 6, 10, 5, 3, 9, 2, 7, 4, 1 };
            Console.Write("排序前：");
            printArray(array);
            insertSort(ref array);
            Console.WriteLine();
            Console.Write("排序後：");
            printArray(array);
            Console.ReadLine();
        }
    }
}
