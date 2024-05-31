using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(' ');
            string[] time2 = Console.ReadLine().Split(' ');
            int time1 = (Convert.ToInt32(time[0]) * 60) + Convert.ToInt32(time[1]);
            int time3 = (Convert.ToInt32(time2[0]) * 60)+ Convert.ToInt32(time2[1]);
            int end = time3 - time1;
            int tmp = end / 30;
            int money = 0;
            if (tmp >= 8)
            {
                money += (60 * (tmp - 7));
            }
            tmp = tmp-(tmp-7);
            if (tmp >=4) 
            {
                money += (40 * (tmp - 3));
            }
            tmp = tmp -(tmp-2);
            money += (30 * tmp);
            Console.WriteLine(money);

            Console.ReadKey();
            }
        }
    }

