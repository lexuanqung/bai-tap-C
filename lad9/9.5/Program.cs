using System;

namespace _9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ARR a = new ARR();
            int n;
            Console.WriteLine(
                "Chuong trinh quan li san pham cua shop ABC.\n" +
                "===========================================\n" +
                "1-khoi tao danh sach.\n" +
                "2-them mot san pham vao danh sach.\n" +
                "3-xoa mot san pham ra khoi danh sach.\n" +
                "4-duyet danh sach.\n" +
                "5-tim thong tin san pham theo ten.\n" + 
                "6-tim san pham theo gia tien.\n" +
                "7-tim san pham theo khoang gia tien.\n" +
                "8-sap xep danh sach theo giam dan.");
            Console.Write("Moi chon: ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (n)
                {
                    case 2:
                        PRODUCT c = new PRODUCT();
                        a.themsanpham(c);
                        c.output();
                        break;
                    case 3:
                        a.xoasanpham();
                        break;
                    case 4:
                        a.duyetdanhsach();
                        break;
                    case 5:
                        a.timdanhsachtheoten();
                        break;
                    case 6:
                        a.timthongtintheogia();
                        break;
                    case 7:
                        a.timsanphantheokhoanggia();
                    default:
                        Console.WriteLine("Moi ban chon tu 1 - 8");
                        break;
                }

            } while (n != 0);

        }
    }
}
