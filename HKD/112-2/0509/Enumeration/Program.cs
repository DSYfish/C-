using System;

namespace Enumeration
{
    internal class Program
    {
        static void print(string s)
        {
            Console.WriteLine(s);
        }
        static int find_mininum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        static void find_all_numbers(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    //print($"{i.ToString().PadLeft(array.Length/10)}:{array[i]}");
                    print($"{i}:{array[i]}");
                    break;
                }
            }
        }
        static bool find_number(int[,] arr, int n)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j <arr.GetLength(1); j++)
                {
                    if (arr[i,j] == n)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 9, -8, 1 };
            int[,] arr2 = {
                                    { 1, 2, 3, 4, 5,},
                                    { 3, 6, 9, -8, 1}
                                    };

            print($"最小值：{ find_mininum(arr)}");
            find_all_numbers(arr, 9);
            print((find_number(arr2, 9) ? "找到":"找不到"));
            Console.ReadKey();
        }
    }
}
