using System;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int n, x;
            Console.Write("Nhap vao mang so nguyen: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} phan tu can luu", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}]", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            x = arr[0];
            int cnt = 0;
            Console.Write("Nhap x= ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (x == arr[i])
                {
                    cnt++;

                }

            }
            Console.WriteLine("Phan tu x={0} co trong mang la. xuat hien {1}", x, cnt);
        }
    }
}
