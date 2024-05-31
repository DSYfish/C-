using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 輾轉相除法
{
    internal class Program
    {
        static int gcd_with_while(int a, int b)
        {
            while( b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return a;
        }


        static int gcd(int a, int b)
        {
            if (b == 0) return a;
            else
                return gcd(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.Write("輸入兩整數：");
            string[] arr = Console.ReadLine().Split(' ');
            int[] nums = { int.Parse(arr[0]), int.Parse(arr[1]) };
            Array.Sort(nums);
            Array.Reverse(nums);
            Console.WriteLine(gcd(nums[0], nums[1]));
            Console.WriteLine(gcd_with_while(nums[0], nums[1]));
            Console.ReadKey();
        }
    }
}
