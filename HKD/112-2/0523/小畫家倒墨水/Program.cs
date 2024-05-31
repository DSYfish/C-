using System;

namespace 小畫家倒墨水
{
    internal class Program
    {
        static ConsoleColor[] colors =
        {
            ConsoleColor.White, 
            ConsoleColor.Black, 
            ConsoleColor.Red, 
            ConsoleColor.Yellow,
        };
        static int[,] image =
            {
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,1,1,0,1,1,0,0},
                {0,0,1,0,0,1,0,0,1,0},
                {0,0,1,0,2,1,0,2,0,0},
                {0,1,0,0,0,0,0,0,1,0},
                {0,1,0,0,1,1,0,1,0,0},
                {0,1,0,0,0,0,0,1,0,0},
                {0,0,1,1,1,1,0,0,1,0},
                {0,1,0,0,1,1,0,0,1,0},
                {0,0,1,1,0,0,1,1,0,0}
            };
        static void flood(int x, int y, int n_color, int o_color)
        {
            if (x >= 0 && x < image.GetLength(1) && y >= 0 && y < image.GetLength(0))
            {
                if (image[x, y] == o_color)
                {
                    image[x, y] = n_color;
                    flood(x + 1, y, n_color, o_color);
                    flood(x - 1, y, n_color, o_color);
                    flood(x, y + 1, n_color, o_color);
                    flood(x, y - 1, n_color, o_color);
                }
            }
        }
        static void show_image(int[,] image)
        {
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    print_with_color("　", image[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void print_with_color(string s, int c = 1, string end = "")
        {
            Console.BackgroundColor = colors[c];
            Console.Write(s + end);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            show_image(image);
            Console.Write("\n　　　塗色後...\n\n");
            flood(3, 3, 3, image[3,3]);
            show_image(image);
            Console.ReadKey();
        }
    }
}
