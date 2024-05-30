using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240523_1
{
    internal class Program
    {
        static int[,] image ={
                {0,0,0,0,0,0,0,0,0,0},{0,0,0,1,1,0,1,1,0,0},{0,0,1,0,0,1,0,0,1,0},{0,0,1,0,2,1,0,2,0,0},{0,1,0,0,0,0,0,0,1,0},{0,1,0,0,1,1,0,1,0,0},{0,1,0,0,0,0,0,1,0,0},{0,0,1,1,1,1,0,0,1,0},{0,1,0,0,1,1,0,0,1,0},{0,0,1,1,0,0,1,1,0,0}
         };
        static void flood(int x, int y, int new_color, int old_color)
        {
            if (x >= 0 && x < 10 && y >= 0 && y < 10)
                if (image[x, y] == old_color)
                {
                    image[x, y] = new_color;
                    flood(x + 1, y, new_color, old_color);
                    flood(x - 1, y, new_color, old_color);
                    flood(x, y + 1, new_color, old_color);
                    flood(x, y - 1, new_color, old_color);
                }
        }
        static void print()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {Console.Write(image[i, j]);}
                Console.WriteLine(); 
        }
            static void Main(string[] args)
        {
            print();
            Console.WriteLine();
            flood(7, 6, 1, image[7, 6]);
            print();
            Console.ReadLine();
        }
    }
}
