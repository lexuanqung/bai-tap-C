using System;

namespace lad4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so n:");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("cac so nguyen chan la:{0}", i);
                    }
                }
            }
            Console.WriteLine("Moi nhap lai!!!");
            Console.ReadKey();
        }
    }
}
