using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231220過半元素
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lis = Console.ReadLine().Split(' ');
            string[] temp = new string[lis.Length];
            int[] count = new int[lis.Length];
            int ind = 0;
            for (int i = 0; i < lis.Length; i++)
            {
                bool io = false;
                for (int j = 0; j < lis.Length; j++) 
                {
                    if (lis[i] == temp[j])
                    {
                        count[j]++;
                        io = true;
                        break;
                    }
                }
                if(io == false)
                {
                    temp[ind] = lis[i];
                    count[ind]++;
                    ind++;
                }
            }
            for (int i = 0; i < ind; ++i)
            {
                if (count[i] > (lis.Length) / 2)
                {
                    Console.WriteLine(temp[i]);
                    break;
                }
                else if (i == ind-1)
                {
                    Console.WriteLine("NO");
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
