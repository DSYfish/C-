using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231213ex1_英文斷詞
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().ToLower().Split(' ');
            string[] words = new string[str.Length];
            int index = 0;

            for (int i = 0; i < str.Length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < index; j++)
                {
                    if (str[i] == words[j])
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    words[index] = str[i];
                    index++;
                }
            }

            for (int i = 0;i < index; i++)
            {
                if (i == index - 1)
                {
                    Console.WriteLine(words[i]);
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }

           // Console.ReadKey();
        }
    }
}
