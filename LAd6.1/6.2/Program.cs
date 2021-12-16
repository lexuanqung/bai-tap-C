using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int n;
            Console.Write("Nhap so a (a!=o):");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so mu n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ket qua {0}^{1} = {2}", a, n, power(a, n));

            Console.ReadKey();
        }
        public static int power(int a, int n)
        {
            int ketqua = 1;
            for (int i = 1; i <= n; i++)
                ketqua = ketqua * a;
            return ketqua;
        }
    }
}
