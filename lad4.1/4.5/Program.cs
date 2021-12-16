using System;

namespace _4._5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    So thich ca nhan    ");
            Console.WriteLine("========================");
            Console.WriteLine("1. Doc sach");
            Console.WriteLine("2. Nghe nhac");
            Console.WriteLine("3. choi the thao");
            Console.WriteLine("4. May tinh");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("========================");

            Console.Write("Chon: ");
            char a = char.Parse(Console.ReadLine());
            switch (a)
            {
                case '1':
                    Console.WriteLine("Ban thich doc sanh?{0}", a);
                    break;
                case '2':
                    Console.WriteLine("Ban thich nghe nhac{0}", a);
                    break;
                case '3':
                    Console.WriteLine("ban thich choi the thao{0}", a);
                    break;
                case '4':
                    Console.WriteLine("Ban thich may tinh{0}", a);
                    break;
                case '5':
                    Console.WriteLine("hen gap lai?{0}", a);
                    break;
                default:
                    Console.WriteLine("Moi nhap lai");
                    break;
            }
            Console.ReadLine();
        }
    }
}
