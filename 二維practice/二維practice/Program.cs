using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] number = { { 1, 4, 2 }, { 3, 6, 8 } };
            for(int i =0;i<number.GetLength(0);i++)
            {
                for(int j=0;j<number.GetLength(1);j++)
                {
                    Console.Write(number[i, j] + "\t");
                }
            }
            Console.WriteLine();

            int max = number[0,0];
            for (int i = 1; i < number.GetLength(0); i++)
            {
                for (int j = 0;j<number.GetLength(1); j++)
                    if (number[i,j] > max)
                        max = number[i,j];
            }
            
            Console.WriteLine("最大值:"+max);

            foreach (int i in number)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            max = number[0,0];
            foreach (int i in number)
            {
                if (i > max) max = i;
            }
            Console.WriteLine("最大值:" + max);

            Console.ReadKey();
        }
    }
}
