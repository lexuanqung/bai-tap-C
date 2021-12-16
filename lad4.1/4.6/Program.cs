using System;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.Write("Nhap vao so bat ki:");
            n = Convert.ToString(Console.ReadLine());
            long sum = 0;

            for (int i = 1; i < n.Length; i++)
            {
                sum += (int)(i - '0');
            }
            Console.WriteLine(sum);
        }
    }
}
