using System;

namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int dem = 0;
            Console.WriteLine("Moi nhap 10 so hoan thien: ");
            for (; dem < 10;)
            {
                Console.Write("So thu {0}:  ", (dem + 1));
                arr[dem] = int.Parse(Console.ReadLine());
                if (hoanhao(arr[dem]) == true) dem++;
                else Console.WriteLine("Ban phai nhap so hoan thien!");
            }
            Console.WriteLine("Mang 10 so da nhap: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,5}", arr[i]);
            }
        }public static Boolean hoanhao(int n)
        {
            int uoc = 0;
            for (int i = 1; i <n; i++)
            {
                if (n % i == 0)
                {
                    uoc = uoc + i;
                }
            }
            if (uoc == n)
            {
                return true;
            }else return false;
        }
    }
}
