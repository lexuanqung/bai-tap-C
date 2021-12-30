using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _9._5
{
    class ARR 
    {
        List<PRODUCT> arraylst = new List<PRODUCT>();
        public void themsanpham(PRODUCT a)// thêm sản phẩm
        {
            arraylst.Add(a);
        } public void xoasanpham()// xoa 1 sản phẩm
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach chưa có sản phẩm nào"); }
            else
            {
                Console.Write("Ban muon xoa sản phẩm nào: ");
                string name = Console.ReadLine();
                int xoa = -1;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if (arraylst[i].get_ten() == name)
                    {
                        arraylst[i].output();
                        xoa = i;
                    }
                }
                if (xoa == -1) { Console.WriteLine("Khong tim thay san pham {0}", name); }
                else
                {
                    Console.Write("Ban muon xoa san pham nay??" +
                                    "Y             N");
                    char n = char.Parse(Console.ReadLine());
                    if (n == 'Y')
                    {
                        arraylst.RemoveAt(xoa);
                        Console.WriteLine("Da xoa san pham!");
                    }
                    else { Console.WriteLine("Ban da huy xoa. Cam on ban!!!!"); }
                }
            }
        }
        public void duyetdanhsach()//duyet danh sach
        {
            for (int i = 0; i < arraylst.Count; i++)
            {
                arraylst[i].printtitle();
                arraylst[i].output(i);
            }
        } public void timdanhsachtheoten()// tìm sản phẩm theo danh sách
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach chua co san pham nao!!"); }
            else
            {
                Console.Write("Moi nhap ten: ");
                string ten = Console.ReadLine();
                
                bool tim = false;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if (arraylst[i].get_ten().Contains(ten))
                    {
                        arraylst[i].output(i);
                        tim = true;
                    }
                }
                if (!tim) Console.WriteLine("Khong co san pham {0} trong danh sach", ten);
            }
        } public void timthongtintheogia()
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach chua co san pham nao!!"); }
            else
            {
                Console.Write("Nhap gia san pham: ");
                double gia = Convert.ToDouble(Console.ReadLine());
                bool tim = false;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if (arraylst[i].get_giaban() == gia)
                    {
                        arraylst[i].output(i);
                        tim = true;
                    }
                } while (!tim) Console.WriteLine("Khong tim thay gia san pham {0}", gia);
            }
        } public void timsanphantheokhoanggia()
        {
            if (arraylst.Count == 0) { Console.WriteLine("Danh sach cha co san pham nao!!"); }
            else
            {
                Console.Write("Moi nhap so Min: ");
                double min = double.Parse(Console.ReadLine());
                Console.Write("Moi nhap so Max: ");
                double max = double.Parse(Console.ReadLine());
                Console.WriteLine("ban dang tim gia ban san pham tu {0} ---> {1}", min, max);
                bool tim = false;
                for (int i = 0; i < arraylst.Count; i++)
                {
                    if (arraylst[i].get_giaban() >= min || arraylst[i].get_giaban() <= max)
                    {
                        arraylst[i].output(i);
                        tim = true;
                    }
                } while (!tim) { Console.WriteLine("Khong tim thay gia ban san pham tu {0} ----> {1}", min, max); }
            }
        }public void sapxeptheogiavaten()
        {
            arraylst.Sort(new Sortbymarkandname());           
            System.Console.WriteLine("Danh sap duoc sap sep giam dan theo gia ban va tang dan theo ten");
            
        }


    }
   

}
