using System;

namespace 人潮最多的時段B
{
    internal class Program
    {
        static int cmp(int x, int y)
        {
            if (Math.Abs(x) > Math.Abs(y)) return 1;
            else if (Math.Abs (x) < Math.Abs(y)) return -1;
            else return 0;
          }
        static void Main(string[] args)
        {
            int[] Guest = { 2,-5,1,-11,3,-7,8,-12};
            Array.Sort(Guest,cmp);
            int count = 0, maxCount = 0;
            for (int i = 0; i < Guest.Length; i++)
            {
                if (Guest[i] > 0)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if(count > maxCount)
                {
                    maxCount = count;
                }
            }
            Console.WriteLine($"人潮最多的時段有{maxCount}人");
            Console.ReadKey();
        }
    }
}
