using System;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Nhap 1 chuoi: ");
            string chuoi = Console.ReadLine();
            Console.WriteLine("co {0} ki tu trong chuoi", chuoi.Length);
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == 'a' || chuoi[i] == 'u' || chuoi[i] == 'e' || chuoi[i] == 'i' || chuoi[i] == 'o')
                {
                    Console.WriteLine("ki tu {0} la nguyen am", chuoi[i]);
                }
                else Console.WriteLine("Ki tu {0} la phu am", chuoi[i]);

            }
            Console.WriteLine("Character: " + chuoi.Replace(" ","").Length);

        }
    }
}
