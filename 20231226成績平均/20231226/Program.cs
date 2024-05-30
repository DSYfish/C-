using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入班上有幾位同學?");
            int people =int.Parse(Console.ReadLine());
            int[] ints = new int[people];
            for (int i = 0;i <= people;i++) 
            {
                Console.Write($"第{i+1}位同學本學期修讀幾科:");
                int project= int.Parse(Console.ReadLine());
                int[] projects = new int[project];
                for(int j=0;j <= project; j++)
                {
                    Console.Write($"第{i+1}位同學第{j+1}科成績:");
                    int x = int.Parse(Console.ReadLine());
                    projects[j] = x;
                }
                Console.Write($"第{i+1}位同學每科成績:");
                int sum = 0;
                for (int j = 0; j <= project; j++)
                {
                    Console.Write($"{projects[j]} ");
                    sum += projects[j];
                }
                Console.ReadLine();
                Console.WriteLine($"第{i+1}位同學平均成績:"+sum/project);
            }
            Console.ReadLine();
        }
    }
}
