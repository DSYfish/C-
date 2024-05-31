using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240516_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array ={2, 3, 5, 7, 11,13, 17, 19, 23, 29,31, 37, 41, 43, 47};
        
            int left = 0,right = array.Length-1, n = 29;
            bool found = false;
            Console.Write("請輸入你要找的數字：");
            n = int.Parse(Console.ReadLine());
            while(left <= right) 
            {
                int mid = left + (right-left)/2;
                if (array[mid] < n)
                {
                    left = mid + 1;
                }
                else if (array[mid] > n)
                {
                    right = mid - 1;
                }
                else
                {
                    found = true;
                    Console.WriteLine(mid+ ": " + array[mid]);
                    break;
                }
            }
            if(found == false)
            {
                Console.WriteLine("沒有找到：" + n);
            }
            Console.ReadLine();
        }
    }
}
