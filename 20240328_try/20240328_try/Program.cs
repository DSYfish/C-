using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240328_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] x = { 1, 2, 3 };
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(x[n]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { Console.WriteLine("完成"); }

            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (z == 0)
            {
                throw new ArithmeticException("分母不可為0");
            }
            else
            {
                Console.WriteLine(y/z);
            }
            Console.ReadLine();
            

        }
    }
}
