using System;

namespace 英文單字從單數變複數
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "study";
            if (s[s.Length - 1] == 'y')
                Console.WriteLine(s.Substring(0, s.Length - 1) + "ies");
            else if (s[s.Length - 1] == 's' || s[s.Length - 1] == 'x')
                Console.WriteLine(s + "es");
            else if (s.Substring(s.Length - 2, 2) == "sh" || s.Substring(s.Length - 2, 2) == "ch")
                Console.WriteLine(s.Substring(0, s.Length - 3) + "es");
            else if (s.Substring(s.Length - 3, 3) == "man")
                Console.WriteLine(s.Substring(0, s.Length - 3) + "men");
            else
                Console.WriteLine(s + "s");
            Console.ReadKey();
        }
    }
}
