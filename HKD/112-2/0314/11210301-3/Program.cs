using System;

namespace _11210301_3
{
    internal class Program
    {
        static void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void game(ref int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,50);//不包括50
            }
        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            Console.WriteLine($"n={n}, m={m}");
            swap(ref n, ref m);
            Console.WriteLine($"n={n}, m={m}");

            int[] arr2 = new int[6];
            game(ref arr2);
            foreach (int i in arr2)
            {
                Console.Write($"{i},");
            }
            Console.ReadKey();
        }
    }
}
