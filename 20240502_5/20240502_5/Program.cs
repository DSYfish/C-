using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240502_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 6, 9, 9, 1 };
            int[] c= new int[10];
            for (int i = 0; i < array.Length; i++) 
            {
                c[array[i]]++;
            }
            int index = 0;
            for (int i = 0;i < c.Length; i++)
            {
                for(int j = 0; j < c[i];j++)
                {
                    array[index++] = i;
                }
            }
            foreach (int data in array)
            {
                Console.WriteLine(data+" ");
            }
            Console.ReadLine();
        }
    }
}
