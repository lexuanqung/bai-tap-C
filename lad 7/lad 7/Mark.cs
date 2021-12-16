using System;
using System.Collections.Generic;
using System.Text;

namespace lad_7
{
    public class Mark
    {
        string Tenmonhoc;
        float DiemLT;
        float DiemTH;
        /*public void mark(string Tenmonhoc, float DiemLT, float DiemTH)
        {
            this.Tenmonhoc = Tenmonhoc;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
        }*/
        public float DiemTB()
        {
            return (DiemLT + DiemTH) / 2;
        }
        public void input()
        {
            Console.WriteLine("THONG TIN VE MON HOC");
            Console.WriteLine("==================================");
            Console.Write("Nhap ten mon hoc:");
            Tenmonhoc = Console.ReadLine();
            Console.Write("Nhap diem LT:");
            DiemLT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem TH:");
            DiemTH = Convert.ToInt32(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Diem LT: {0}", DiemLT);
            Console.WriteLine("Diem TH: {0}", DiemTH);
            Console.WriteLine("Diem TB: {0}", DiemTB());
        }
    }
}
