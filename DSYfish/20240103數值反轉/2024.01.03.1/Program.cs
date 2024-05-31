using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2024._01._03._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一整數:");
            int ans = int.Parse(Console.ReadLine());
            { 
               while (ans > 0)
                {
                    Console.Write(ans%10);
                    ans /= 10;
                }
            }
            Console.ReadKey();
        }
    }
}
