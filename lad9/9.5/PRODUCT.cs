using System;
using System.Collections.Generic;
using System.Text;

namespace _9._5
{
    class PRODUCT
    {
        string tensanpham;
        string motasanpham;
        double giaban;
        public void input()
        {
            Console.Write("Nhap ten san pham: ");
            tensanpham = Console.ReadLine();
            Console.Write("Mo ta san pham: ");
            motasanpham = Console.ReadLine();
            Console.Write("Gia ban: ");
            giaban = Convert.ToDouble(Console.ReadLine());
        }public string get_ten() { return tensanpham; }
        public string get_mota() { return motasanpham; }
        public double get_giaban() { return giaban; }
        public void set_ten(string newten) { this.tensanpham = newten; }
        public void set_mota(string newmota) { this.motasanpham = newmota; }
        public void set_giaban(double newgiaban) { this.giaban = newgiaban; }
        public void printline() { Console.WriteLine("---------------------------------------------------------"); }
        public void printtitle()
        {
            Console.WriteLine("| {0,-5} | {1,-12} | {2,-15} | {3,-20} | ", "STT", "tensanpham", "motasanpham", "giaban");
        }
        public void output(int STT)
        {
            Console.WriteLine("| {0,-5} | {1,-12} | {2,-15} | {3,-20} |  ", STT, tensanpham, motasanpham, giaban);
        }public void output()
        {
            Console.WriteLine("| {0,-5} | {1,-12} | {2,-15} |", tensanpham, motasanpham, giaban);
        }
    }
}
