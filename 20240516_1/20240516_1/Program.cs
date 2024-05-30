using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240516_1
{ 
    internal class Program
    {
      
        
        static void Main(string[] args)
        {
            int[] array = { 3, 6, 1, 7, 2 };
            int i =0, j = -1;
            int sum1 = 0;
            while (j < array.Length)
            {
                if (sum1< 10)
                {j++;sum1 += array[j];}
                else if (sum1 > 10)
                {sum1 -= array[i];i++;}
                else{
                    j++;
                   if (j >= array.Length)break ; 
                   sum1 += array[j];
                }
               
                if (sum1 == 10)
                {
                    Console.WriteLine($"[{i}, {j}]");
                }
            }
            Console.ReadKey();
        }
    }
}
