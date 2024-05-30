using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240509_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "It;s a pencil.";
            string pattern = "a pen";
            for (int i = 0; i < text.Length-pattern.Length+1; i++)
            {
                bool find = true;
                for (int j = 0;j<pattern.Length;j++)
                {
                    if (text[i+j] != pattern[j])find = false;
                    break;
                }
                if (find)
                {
                    Console.WriteLine("短字串出現在第" + i + "個字元");
                }

            }
            Console.ReadLine();

        }
    }
}
