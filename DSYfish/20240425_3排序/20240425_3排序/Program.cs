using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240425_3排序
{
    internal class Program
    {
        static void selectionSort(int[] array)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[min_index])
                        min_index = j; 
                int tmp;
                tmp = array[i];
                array[i] = array[min_index];
                array[min_index] = tmp;
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 6, 9, -8, 1 };
            selectionSort(array);
            foreach(int i in array) { Console.Write(i + " "); };
            Console.ReadLine();
        }
    }
}
