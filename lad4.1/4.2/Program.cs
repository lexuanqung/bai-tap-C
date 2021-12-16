using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so: ");
            int a = int.Parse(Console.ReadLine());
            bool b = true;
            while (a <= 1)
            {
                Console.WriteLine("Moi nhap lai:");
                a = int.Parse(Console.ReadLine());
            }
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    b = false;
                    break;
                }
            }
            if (b)
            {
                Console.WriteLine("So nguyen to:{0}", a);
            }
            else Console.WriteLine("Khong phai so nguen to:{0}", a);
            Console.ReadKey();
        }
    }
}
