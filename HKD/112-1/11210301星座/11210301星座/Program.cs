using System;


namespace _11210301星座
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int m = int.Parse(str[0]) - 1;
            int d = int.Parse(str[1]);
            //月份          1   2   3   4   5   6   7   8   9  10  11  12
            int[] star = { 21, 19, 21, 21, 22, 22, 23, 24, 24, 24, 23, 22 };
            string[] starstr = { "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "irgo", "Libra", "Scorpio", "Sagittarius", "Capricorn" };
            if( d >= star[m])
            {
                Console.WriteLine(starstr[m]);
            }
            else
            {
                if(m - 1 < 0) 
                {
                    m = starstr.Length - 1;
                }
                Console.WriteLine(starstr[m - 1]);
            }
                Console.ReadKey();
        } 
    }
}
