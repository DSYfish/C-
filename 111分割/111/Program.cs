using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                String[] arr = Console.ReadLine().Split(' ');
                char m = char.Parse(arr[0]);
                int a1 = int.Parse(arr[1]);
                int a2 = int.Parse(arr[2]);
                int b1 = int.Parse(arr[3]);
                int b2 = int.Parse(arr[4]);
                switch(m) 
                {
                    case '+':
                        Console.WriteLine((a1 + b1) + " " + (b2 + a2));
                        break;
                    case '-':
                        Console.WriteLine((a1 - b1) + " " + (b2 - a2));
                        break;
                    case '*':
                        Console.WriteLine((a1 + b1)*(a2+b2));
                        break;
                    case '/':
                        Console.WriteLine((a1 - b1) * (a2 - b2) / (a2 + b2) * (a2 - b2));
                        break;
                }
            }   n = n - 1;
        }
    }
}
