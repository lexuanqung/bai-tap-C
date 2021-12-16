using System;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int diem;
            Console.Write("Nhap vao so diem bat ki(!=0):");
            diem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So diem {0} thuoc hang {1}", diem, diemhang(diem));

        }
        public static char diemhang(double diem)
        {
            if ((diem >= 8.5) && (diem <= 10))
            {
                return 'A';
            }
            else if ((diem >= 7) && (diem <= 8.4))
            {
                return 'B';
            }
            else if ((diem >= 5.5) && (diem <= 6.9))
            {
                return 'C';
            }
            else if ((diem >= 4) && (diem <= 5.4))
            {
                return 'D';
            }
            else return 'E';

        }
    }
}
