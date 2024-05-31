using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質因數分解
{
    internal class Program
    {
        static string intf(int n)
        {
            if (n < 2) return n.ToString(); 
            for (int i = 2;  i < n; i++)
            {
                if(n % i == 0)
                {
                    return $"{i}x{intf(n / i)}";
                }
            }
            return n.ToString();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("輸入整數(exit 離開)");
                    Console.WriteLine(intf(int.Parse(Console.ReadLine())));
                }
                catch 
                {
                    break;
                }
            }
            
        }
    }
}
