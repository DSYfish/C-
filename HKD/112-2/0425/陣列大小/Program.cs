using System;
using System.Collections.Generic;

namespace 陣列大小
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>();
            nums.Push(3);
            nums.Push(6);
            nums.Push(9);
            Console.WriteLine($"Count:{nums.Count}");
            while (nums.Count > 0)
            {
                Console.WriteLine(nums.Pop());
            }
            Console.WriteLine($"Count:{nums.Count}");
            Console.ReadKey();
        }
    }
}
