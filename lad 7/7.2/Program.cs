using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Product[] a = new Product[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Product();
                Console.WriteLine("San pham thu: " + (i + 1));
                a[i].input();

            }
            Console.WriteLine("Danh muc san pham");
            Product.print_title();
            long sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i].output(i+1);
                sum += a[i].sum();

            }Product.printline();
            Console.WriteLine("|{0,69|",sum);
            Product.printline();

        }
    }
}
