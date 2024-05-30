using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a =Console.ReadLine().Split(' ');
            float[] nums = new float[a.Length];
            
            for (int i = 0;i < a.Length; i++) 
            {
                nums[i] = float.Parse(a[i]);
            }
            float max = nums[0];
            float min = nums[1];
            foreach (int i in nums)
            {
                if (i > max)max = i;
                if (i < min)min = i;
            }
            Console.WriteLine($"maxmum:{max.ToString("f2")}");
            Console.WriteLine($"minmum:{min.ToString("f2")}");

            Console.ReadLine();
            

        }
    }
}
