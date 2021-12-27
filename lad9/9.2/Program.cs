using System;
using System.Collections;
using System.Collections.Generic;

namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new ArrayList();
            int input()
            {
                return int.Parse(Console.ReadLine());
            }
            Console.WriteLine(
                "Demo cac thao tac tren Stack so nguyen JAVA.\n"+
                "==============================================\n"+
                "1-khoi tao Stack.\n"+
                "2-them 1 phan tu vao Stack.\n"+
                "3-lay phan tu dau ra khoi Stack.\n"+
                "4-xem phan tu dau Stack.\n"+
                "5-duyet Stack.\n"+
                "0-thoat.\n" +
                ""+
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
                        arr.Add(input());
                        break;
                        //lay phan tu dau cua mang
                    case "3":
                        Console.Write("Ban muon lay phan tu dau ra khoi Stack????" +
                                        "   Y                     N");
                        char a = char.Parse(Console.ReadLine());
                        if (a=='Y'|| a=='N')
                        {
                            arr.RemoveAt(0);

                        }
                        break;
                        //xem phan tu dau cua mang
                    case "4":
                        Console.Write("Ban muon xem phan tu dau Stack????" +
                                        "   Y                     y");
                        char b = char.Parse(Console.ReadLine());
                        if (b == 'Y' || b == 'y')
                        {
                            Console.WriteLine("phan tu dau cua mang la: " + arr[0]);

                        }
                        break;
                        // duyet Stack
                    case "5":
                        for (int i = 0; i < arr.Count; i++)
                        {
                            Console.WriteLine(i + " " +arr[i]);
                        }break;
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
