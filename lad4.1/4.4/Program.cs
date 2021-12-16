using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 ki tu:");
            char a = char.Parse(Console.ReadLine());

            if ((a >= '0' && a <= '9') || (a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z'))
            {
                Console.WriteLine("Ki tu dac biet:{0}", a);
            }
            else
                Console.WriteLine("khong phai ki tu");
        }
    }
}
