using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuckthisworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("猜數字遊戲，1到100 猜一個：");
            Random rnd = new Random();
            int guess = int.Parse(Console.ReadLine());
            int count = 0, max = 100, min = 1;
            int ran = rnd.Next(min,max+1);
            while (ran != guess) 
            {
                if (guess>=max || guess <= min)
                {
                    Console.WriteLine("無效值");
                }
                if (ran > guess)
                {
                    min = guess+1;
                    Console.WriteLine($"再大一點,{max}~{min}");
                    count ++;
                }
                else 
                {

                    max = guess-1;
                    
                    Console.WriteLine($"再小一點,{max}~{min}");
                    count ++;
                }
                guess =int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"恭喜你猜對了，答案是{ran}，你總共猜了{count}次");
            Console.ReadKey();
              
            
        }
    }
}
