using System;


namespace 費氏數列
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int f1 = 1;
            int f2 = 1;
            int fn = 0;
            if (n < 3) 
                fn = 1;
            else
            {
                for(int i = 3; i <= n; i++)
                {
                    fn = f1 + f2;
                    f1 = f2;
                    f2 = fn;
                }
            }
            Console.WriteLine(fn);
            Console.ReadKey();
        }
    }
}
