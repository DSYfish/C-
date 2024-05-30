using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202405016_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "study";
            s = Console.ReadLine();
            if (s[s.Length - 1] == 'y')
                Console.WriteLine(s.Substring(0, s.Length - 1) + "ies");
            else if (s[s.Length - 1] == 's' || s[s.Length - 1] == 'x')
                Console.WriteLine(s.Substring(0, s.Length) + "es");
            else if (s.Substring(s.Length - 2, 2) == "ch" || s.Substring(s.Length - 2, 2) == "sh")
                Console.WriteLine(s.Substring(0, s.Length) + "es");
            else if (s.Substring(s.Length - 3, 3) == "man")
                Console.WriteLine(s.Substring(0,s.Length-3)+ "men");
            else
                Console.WriteLine(s +"s") ;
            Console.ReadKey ();
        }
    }
}
