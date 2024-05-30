using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240523_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            n = int.Parse(Console.ReadLine());
            int f1 = 1;
            int f2 =1;
            int fn = 0;
            if(n<3)
                fn = 1;
            else
            {
                for(int i = 3; i<=n; i++)
                {
                    fn = f1 + f2;
                    f1 = f2;
                    f2 = fn;
                }
            }

            Console.WriteLine(fn);
            Console.ReadKey ();
        }
    }
}
