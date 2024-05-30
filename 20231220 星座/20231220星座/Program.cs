using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231220星座
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] date = Console.ReadLine().Split(' ');
            int month = int.Parse(date[0]);
            int day = int.Parse(date[1]);
            int[] star = { 21, 19, 21, 21, 22, 22, 23, 24, 24, 24, 23, 22 };
            string[] starStr = { "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio","Sagittarius","Capricorn"};
            if (day >= star[month-1]) 
            {
                Console.WriteLine(starStr[month - 1]);
            }
            else
            {
                Console.WriteLine(starStr[month]);
            }



            Console.ReadKey();
        }
    }
}
