using System;

namespace _11210301_MaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] str = Console.ReadLine().Split();
                float[] nums = new float[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    nums[i] = float.Parse(str[i]);
                }
                float max, min = max = nums[0];
                foreach (float i in nums)
                {
                    if(i > max) max = i;
                    if(i < min) min = i;
                }
                Console.WriteLine($"maximum:{max.ToString("f2")}");
                Console.WriteLine($"minimum:{min.ToString("f2")}");
                
                
                Array.Sort(nums);
                Console.WriteLine($"maximum:{(nums[nums.Length-1]).ToString("f2")}");
                Console.WriteLine($"minimum:{(nums[0]).ToString("f2")}");
                Console.ReadLine();
            }
        }
    }
}
