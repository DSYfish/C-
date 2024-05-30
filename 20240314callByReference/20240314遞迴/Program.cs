using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _20240314callByReference
{
    internal class Program
    {
        static int gcd(int n, int m)
        {
            if (m==0) return n;
            return gcd(m, n%m);
        }
        static void callByValue(int n, int m)
        {
            //互不影響，只取值沒回傳
            n += 2;
            m += 3;
        }

        static void callByReference(ref int n, ref int m)
            //ref 記憶體位置，影響到外面的話需要使用ref
        {
            n += 2;
            m += 3;
        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            Console.WriteLine("gcd ="+gcd(n, m));
            callByValue(n, m);
            //n 會以原本的值輸出
            Console.WriteLine("n =" + n + ", m =" + m);
            callByReference(ref n,ref m);
            Console.WriteLine("n =" + n + ", m =" + m);
            Console.ReadKey();
        }
    }
}
