using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240502_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 10, 11, 1000000000, 23, 99, 123, 514, 3, 4 };
            Dictionary<int,int> mapTable = new Dictionary<int,int>();

            foreach(int i in array)
            {
                if (mapTable.ContainsKey(i))
                {mapTable[i] ++;}
                else
                {mapTable.Add(i, 1);}
            }

            foreach(int key in mapTable.Keys)
            {
                Console.WriteLine(key + ":" + mapTable[key]);
            }
            Console.ReadKey();
        }
    }
}
