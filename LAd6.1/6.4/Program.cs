using System;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so bat ki: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(checknumber(n));
        }
        public static Boolean checknumber(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return true;
            }
            return false;
        }
    }
}
