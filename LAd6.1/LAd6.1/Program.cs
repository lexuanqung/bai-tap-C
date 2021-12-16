using System;

namespace LAd6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            giaipt(a, b, c);



        }
        static void giaipt(int a, int b, int c)
        {
            Console.Write("Nhap a (a!=0):");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c:");
            c = Convert.ToInt32(Console.ReadLine());
            long delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                ptvn();
            }
            else if (delta == 0)
            {
                ptnk(a, b);
            }
            else
            {
                ptc2n(a, b, c);
            }


        }
        static void ptvn()
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
        static void ptnk(int a, int b)
        {
            Console.WriteLine("Phuong trinh nghiem kep: x1 = x2 = {0}", -b / (2 * a));

        }
        static void ptc2n(int a, int b, int c)
        {
            long delta = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta) / 2 * a);
            double x2 = (-b - Math.Sqrt(delta) / 2 * a);

            Console.WriteLine("Phuong trinh co 2 nghiem pb: x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
