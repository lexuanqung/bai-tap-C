using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so M:");
            int m = int.Parse(Console.ReadLine());

            while ((n <= 0) || (m < n))
            {
                Console.WriteLine("moi nhap lai so N:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Moi nhap lai so M:");
                m = int.Parse(Console.ReadLine());
            }
            for (int i = n; i <= m; i++)
            {
                if (i % 7 == 0) Console.WriteLine("Xuat ra la:{0}", i);
            }
            Console.ReadKey();
        }
    }
}
