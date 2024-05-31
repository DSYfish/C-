using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240103期末模擬考第三題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入3列OX資料中間用空白區隔：");
            string[,] gameboard = new string[3, 3];
            bool result = false;
            for (int i = 0; i < 3; ++i)
            {
                string[] temp = Console.ReadLine().Split(' ');
                gameboard[i, 0] = temp[0];
                gameboard[i, 1] = temp[1];
                gameboard[i, 2] = temp[2];
            }
            for (int j = 0; j < 3; ++j)
            {
                if (gameboard[j, 0] == gameboard[j, 1] & gameboard[j, 1] == gameboard[j, 2])
                {
                    result = true;
                }
                else if (gameboard[0, j] == gameboard[1, j] & gameboard[1, j] == gameboard[2, j])
                {
                    result = true;
                }
            }
            if (gameboard[0, 0] == gameboard[1, 1] & gameboard[1, 1] == gameboard[2, 2])
            {
                result = true;
            }
            else if (gameboard[2, 0] == gameboard[1, 1] & gameboard[1, 1] == gameboard[0, 2])
            {
                result = true;
            }
            if (result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
    }
}
   
