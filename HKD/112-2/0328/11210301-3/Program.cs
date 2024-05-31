using System;
using System.Reflection;

namespace _11210301_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] x = { 1, 2, 3, 4, 5, 6, };
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(x[n]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
             }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (z == 0)
            {
                throw new ArgumentException("分母不得為零");
            }
            else
            {
                Console.WriteLine(y / z);
            }
            Console.ReadKey();
        }
    }
}
