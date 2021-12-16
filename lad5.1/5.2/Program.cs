using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int n, mx, mn;
            Console.Write("Nhap so phan tu can luu:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap {0} phan tu ca luu:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("phan tu [{0}]", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            mx = arr[0];
            mn = arr[0];
            int dem = 0;
            int dem2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > mx)
                {
                    mx = arr[i];
                    
                }
                
                if (arr[i] < mn)
                {
                    mn = arr[i];
                    
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == mx) { dem++; }
                if (arr[i] == mn) { dem2++; }

            }

            Console.WriteLine("Max = {0} xuat hien {1}", mx, dem);
            Console.WriteLine("Min = {0} xuat hien {1}", mn, dem2);
        }
    }
}
