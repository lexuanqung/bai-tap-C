using System;
using System.Collections.Generic;
using System.Text;

namespace _9._5
{
    class ARR
    {
        List<PRODUCT>  arraylst = new List<PRODUCT>();
        public void themsanpham(PRODUCT a)// thêm sản phẩm
        {
            arraylst.Add(a);
        }public void xoasanpham(PRODUCT pRODUCT)// xoa 1 sản phẩm
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach chưa có sản phẩm nào"); }
            else
            {
                Console.Write("Ban muon xoa sản phẩm nào: ");
                string name = Console.ReadLine();
                int xoa = -1;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if(arraylst[i].get_ten() == name)
                    {
                        arraylst[i].output();
                        xoa = i;
                    }
                }
                if (xoa == -1) { Console.WriteLine("Khong tim thay san pham {0}", name); }
                else
                {
                    pRODUCT.printline();
                    Console.Write("Ban muon xoa san pham nay??"+ 
                                    "Y             N");
                    char n = char.Parse(Console.ReadLine());
                    if(n == 'Y')
                    {
                        arraylst.RemoveAt(xoa);
                        Console.WriteLine("Da xoa san pham!");
                        pRODUCT.printline();
                    }
                    else { Console.WriteLine("Ban da huy xoa. Cam on ban!!!!"); }
                }
            }
        }public void duyetdanhsach()//duyet danh sach
        {
            for (int i = 0; i < arraylst.Count; i++)
            {
                Console.WriteLine(i + " " + arraylst[i]);
            }
        }public void timdanhsachtheoten(PRODUCT pRODUCT)// tìm sản phẩm theo danh sách
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach chua co san pham nao!!"); }
            else
            {
                Console.Write("Moi nhap ten: ");
                string ten = Console.ReadLine();
                pRODUCT.printline();
                bool tim = false;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if(arraylst[i].get_ten().Contains(ten))
                    {
                        arraylst[i].output(i);
                        tim = true;
                    }
                }
                if (!tim) Console.WriteLine("Khong co san pham {0} trong danh sach", ten);
            }
        }public void timthongtintheogia(PRODUCT pRODUCT, double gia)
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach chua co san pham nao!!"); }
            else
            {
                Console.Write("Nhap gia san pham: ");
                gia = Convert.ToDouble(Console.ReadLine());
                pRODUCT.printline();
                bool tim = false;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if(arraylst[i].get_giaban() == gia)
                    {
                        arraylst[i].output(i);
                        tim = true;
                    }
                } while (!tim) Console.WriteLine("Khong tim thay gia san pham {0}",gia);
            }
        }public void timsanphantheokhoanggia(PRODUCT pRODUCT, double min, double max)
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach cha co san pham nao!!"); }
            else
            {
                Console.Write("Moi nhap so Min: ");
                min = double.Parse(Console.ReadLine());
                Console.Write("Moi nhap so Max: ");
                max = double.Parse(Console.ReadLine());
                Console.WriteLine("ban dang tim gia ban san pham tu {0} ---> {1}", min, max);
                pRODUCT.printline();
                bool tim = false;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if(arraylst[i].get_giaban() >= min || arraylst[i].get_giaban <= max)
                    {
                        arraylst[i].output(i);
                        tim = true;
                    }
                } while (!tim) { Console.WriteLine("Khong tim thay gia ban san pham tu {0} ----> {1}", min, max); }
            }
        }
    }
}
