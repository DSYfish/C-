using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240314練習3
{
    internal class Program
    {
        static void swap(ref int n, ref int m)
        {
            int tmp;
            tmp = n;
            n = m;
            m = tmp;

        }
        static void game(ref int[] arr)
        {
            //樂透
            Random rnd = new Random(); //亂數
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = rnd.Next(1, 50);
                
            }
        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            Console.WriteLine("n =" + n + ", m =" + m);
            swap(ref n, ref m);
            Console.WriteLine("n =" + n + ", m =" + m);
            int[] arr2 = new int[6];
            game(ref arr2);
            foreach(var item in arr2) 
            {
                Console.Write(item + ",");
            }
            Console.ReadKey();
        }
    }
}
