using System;

namespace 選擇排序法
{
    internal class Program
    {
        static void selection_sort(ref int[] arr)
        {
            int tmp =0;
            for(int i = 0; i  < arr.Length; i++) 
            {
                int index = i;
                int min = arr[i];
                for (int j = i; j < arr.Length ; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        index = j;
                    }
                }
                tmp = arr[i];
                arr[i] = min;
                arr[index] = tmp;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 9, -8, 1 };
            selection_sort(ref arr);
            foreach (int v in arr)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
