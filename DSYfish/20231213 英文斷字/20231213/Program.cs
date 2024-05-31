using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lst = Console.ReadLine().ToLower().Split(' ');
            string[] words = new string[lst.Length];
            int index  = 0;
            for (int i  = 0; i < lst.Length; i++)
            {
                bool isFound = false;
                for (int j  = 0; j < index; j++)
                {
                    if (lst[i] == words[j]) 
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    words[index] = lst[i];
                    index++;
                }
            }
            for(int i = 0; i < index;i++)
            {
                Console.Write(words[i]+" ");
            }
            Console.WriteLine();
            Console.ReadLine();


            /*for (int i = 0; i < lst.Length; i++) 
            {   if (words.Contains(lst[i]))
                    {
                    continue;
                    }
                else {words.Append(lst[i]); }
            
            Console.Write(words[i]+" ");
            }

            Console.Write(string.Join(" ",words ));*/
        
            Console.ReadLine();
        }
    }
}
