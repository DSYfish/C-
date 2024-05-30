using System;
using System.IO;


namespace _20240328_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("test.txt");
            using (StreamWriter sw = File.AppendText("F.txt"))
            {
                sw.Write("測試");
                sw.Write("致理科大");
            }
           // string str = File.ReadAllText("test.txt");
           // Console.WriteLine(str);
        }
    }
}
