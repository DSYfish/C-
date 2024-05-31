using System;
using System.Collections.Generic;


namespace 統計數字數量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 10, 11, 1000000000, 23, 99, 12, 3, 514 };
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (map.ContainsKey(i)) map[i]++;
                else map.Add(i, 1);
            }
            foreach (KeyValuePair<int,int> s in map)
            {
                Console.WriteLine($"{s.Key}:{s.Value}");
            }
            Console.ReadKey();
        }
    }
}
