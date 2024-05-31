using System;

namespace 對調陣列
{
    internal class Program
    {
        static void print_r(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
        static void print_r(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i.ToString().PadLeft(2,' ') + " ");
            }
            Console.WriteLine();
        }
        static void swap_int_array(ref int[] arr1, ref int[] arr2)
        {
            int tmp;
            for (int i = 0; i < arr1.Length; i++)
            {
                tmp = arr1[i];
                arr1[i] = arr2[i];
                arr2[i] = tmp;
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 3, 6, 9, -8, 1 };
            int[] b = { 9, 8, 7, 6, 5 };
            print_r(a);
            print_r(b);
            swap_int_array(ref a, ref b);
            Console.WriteLine("Swapped...");
            print_r(a);
            print_r(b);
            Console.ReadKey();
        }
    }
}
