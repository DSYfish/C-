using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace _11210301_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File.Creat("F.txt")
            //File.Copy("F.txt", "F.bak");
            //File.Delete("F.bak");
            if (!File.Exists("F.txt"))
            using (StreamWriter sw = File.AppendText("F.txt"))
            {
                    Console.Write("未發現檔案，正在創建");
                    Thread.Sleep(500);
                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 1; j < 10; j++)
                        {
                            sw.Write($"{i}x{j}={(i * j).ToString().PadLeft(2,'0')}\t");
                        }
                        Thread.Sleep(500);
                        Console.Write(".");
                        sw.WriteLine();
                    }
                    System.Console.Clear();
                    Console.WriteLine("新增完成");
                    Thread.Sleep(2000);
            }
            System.Console.Clear();
            Console.WriteLine("正在列印");
            Thread.Sleep(500);
            int count = 0;
            foreach ( string str in File.ReadLines("F.txt"))
            {
                Console.WriteLine(str);
                count++;
                Thread.Sleep(200);
            }
            Thread.Sleep(1000);
            Console.WriteLine($"列印完成，共{count}行");
            Console.ReadKey();
            File.Delete("F.txt");
        }
    }
}
