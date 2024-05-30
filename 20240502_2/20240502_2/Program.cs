using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240502_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "KHAWN";
            string[] mapTable = {"","1","2","3","","1","2",
                                 "","","2","2","4","5","5",
                                 "","1","2","6","2","3","",
                                 "1","","2","","2"};
            s = Console.ReadLine();
            string output = "";
            for (int i = 0;i<s.Length;i++)
            {
                output += mapTable[s[i]-'A'];   
            }
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
