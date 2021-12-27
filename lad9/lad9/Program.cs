using System;
using System.Collections;
using System.Collections.Generic;

namespace lad9
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            int input()
            {
                return int.Parse(Console.ReadLine());
            }
            Console.WriteLine(
                "Demo thao tac Arraylist so nguyen JAVA.\n" +
                "=========================================.\n"+
                "1- khoi tao danh sach.\n" +
                "2- them 1 phan tu vao danh sach.\n" +
                "3- xoa 1 phan tu ra khoi danh sach.\n" +
                "4- chen 1 phan tu vao danh sach.\n"+
                "5- duyet danh sach.\n" +
                "6- tim 1 phan tu.\n" +
                "7- sap xep danh sach tang dan.\n" +
                "8- sap xep danh sach giam dan.\n" +
                "0- thoat.\n" +
                "=========================================.\n");
            bool chon = true;
            while (chon)
            {
                Console.Write("Moi chon: ");              
                switch (Console.ReadLine()){
                    case "2":
                        Console.Write("Ban muon them gì? ");
                        list.Add(input());
                        break;
                    case "3":
                        Console.WriteLine("Ban muon xoa gi?");
                        list.Remove(input());
                        break;
                    case "4":
                        Console.Write("ban muon chen so nao?");
                        int so = input();
                        Console.WriteLine("Ban muon chen {so} tai ");
                        int index = input();
                        list.Insert(so,index);
                        break;
                        // duyet danhs sach
                    case "5":
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(i + " " + list[i]);
                        }
                        break;
                    case "6":
                        Console.WriteLine("Ban muon tim kiem gi?");
                        int search = input();
                        index = list.IndexOf(search);
                        if (index != -1) { Console.WriteLine("cai {0} có trong danh sach"); }
                        else Console.WriteLine("khong co trg danh sach");
                        break;
                    case "7":
                        list.Sort();
                        Console.WriteLine("danh sach dc sap xep tang dan");
                        break;
                    case "8":
                        list.Sort();
                        list.Reverse();
                        Console.WriteLine("danh sach dc  sap xep giam dan");
                        break;
                    case "0":
                        chon = false;
                        Console.WriteLine("Bye bye!!!!");
                        break;
                    default:
                        Console.WriteLine("hen gap lai ban lan sau nhé ???");
                        break;
                }
            }

        }

    }
}