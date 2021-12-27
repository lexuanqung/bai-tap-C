using System;
using System.Collections;
using System.Collections.Generic;

namespace _9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var listarr = new ArrayList();
            int input()
            {
                return int.Parse(Console.ReadLine());
            }
            Console.WriteLine(
                "Demo cac thao tac tren Queue so nguyen JAVA.\n" +
                "==============================================\n" +
                "1-khoi tao Queue.\n" +
                "2-them 1 phan tu vao Queue.\n" +
                "3-lay phan tu dau ra khoi Queue.\n" +
                "4-xem phan tu dau Queue.\n" +
                "5-duyet Queue.\n" +
                "0-thoat.\n" +
                "" +
                "==============================================");
            bool lool = true;
            while (lool)
            {
                Console.Write("Moi chon so:");
                switch (Console.ReadLine())
                {
                    //them phan tu vao mang
                    case "2":
                        Console.Write("Ban muon them phan tu gì??");
                        listarr.Add(input());
                        break;
                    //lay phan tu dau cua mang
                    case "3":
                        Console.Write("Ban muon lay phan tu dau ra khoi Queue????" +
                                        "   Y                     N");
                        char a = char.Parse(Console.ReadLine());
                        if (a == 'Y' || a == 'N')
                        {
                            listarr.RemoveAt(0);

                        }
                        break;
                    //xem phan tu dau cua mang
                    case "4":
                        Console.Write("Ban muon xem phan tu dau Queue????" +
                                        "   Y                     N");
                        char b = char.Parse(Console.ReadLine());
                        if (b == 'Y' || b == 'N')
                        {
                            Console.WriteLine("phan tu dau cua mang la: " + listarr[0]);

                        }
                        break;
                    // duyet Stack
                    case "5":
                        for (int i = 0; i < listarr.Count; i++)
                        {
                            Console.WriteLine(i + " " + listarr[i]);
                        }
                        break;
                    case "0":
                        lool = false;
                        Console.WriteLine("Bye Bye babe :)");
                        break;
                    default:
                        Console.WriteLine("Hen ban khong gap lai nhe!!!!");
                        break;



                }
            }
        }
    }
}
