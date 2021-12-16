using System;
using System.Collections.Generic;
using System.Text;

namespace _7._2
{
    class Product
    {
        string tensanpham;
        int soluong;
        long dongia;
        public static void printline()
        {
            Console.WriteLine("------------------------------------");
        }public void input()
        {
            printline();
            Console.Write("Ten san pham:");
            tensanpham = Console.ReadLine();
            Console.Write("So luong: ");
            soluong = int.Parse(Console.ReadLine());
            Console.Write("Don gia : ");
            dongia = long.Parse(Console.ReadLine());
            printline();

        }public static void print_title()
        {
            printline();
            Console.WriteLine("|{0,-5} | {1,=20} | {2.10} | {3,15} | {1,15} |", "STT", "Tensanpham", "Soluong", "dongia", "Tongtien");
            printline();
        }public long sum()
        {
            return soluong * dongia;
        }public void output(int STT)
        {
            Console.WriteLine("|{0,-5} | {1,-20} | {2,10} | {3,15} | {4,15} |", STT, tensanpham, soluong, dongia,  sum());
        }

    }
}
