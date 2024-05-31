using System;

namespace 插入排序法
{
    internal class Program
    {
        static void Ins_sort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int target = i;
                for( int j = i - 1; j >= 0; j--)
                {
                    if (arr[target] < arr[j])
                    {
                        int tmp = arr[target];
                        arr[target] = arr[j];
                        arr[j] = tmp;
                        target = j;
                    }
                }
            }
        }
        static void print(int[] arr , int zero_time = 0)
        {
            int len = arr.Length;
            for(int i = 0; i < len - 1; i++)
            {
                print(arr[i].ToString(), ",", zero_time);
            }
            print(arr[len - 1].ToString(), zero_time: zero_time);
        }
        static void print(string s,string end = "\n", int zero_time = 0)
        {
            Console.Write(s.PadLeft(zero_time, '0') + end);
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, 6, 10, 5, 3, 9, 2, 7, 4, 1 };
            print("原數列：", "");
            print(arr, 2); 
            Ins_sort(ref arr);
            print("排序後：", "");
            print(arr, 2);
            Console.ReadKey();
        }
    }
}
