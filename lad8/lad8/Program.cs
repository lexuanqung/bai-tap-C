using System;

namespace lad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Mời nhap vao 1 chuoi ki tu: ");
            string chuoi = Console.ReadLine(); 
            Console.Write("Nhap vao ki tu:");
            char kitu = char.Parse(Console.ReadLine());
            int dem = 0;
            while(chuoi.Length>0){
                for (int i = 0; i < chuoi.Length; i++)
                {
                    if (kitu == chuoi[i])
                    {
                        Console.WriteLine("ki tu {0} co nam trong chuoi", kitu);
                        dem += 1;
                    }
                }
                Console.WriteLine("so lan xuat hien {0}", dem);
            }
        }
    }
}
