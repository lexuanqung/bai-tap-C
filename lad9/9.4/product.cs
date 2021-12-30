using System;
using System.Collections.Generic;
using System.Text;

namespace _9._4
{
    class product
    {
        List<strudent> list = new List<strudent>();
        // khoi tao danh sach


        // them 1 thành viên vao danh sach
        public void themvaodanhsach(strudent s)
        {
            list.Add(s);            
        //duyet danh sach
        }public void duyetdanhsach()
        {
            
            for (int i = 0; i <list.Count; i++)
            {
                list[i].printitle();
                list[i].ouput(i);
                
            }
        //tim sinh vien theo tên
        }public void timthongtinsinhvien()
        {
            Console.Write("Moi nhap ten hoc sinh ban muon  tim: ");
            string ten = Console.ReadLine();
            if (list.Count == 0) { Console.WriteLine("Trong danh sach khong hoc sinh???"); }
            else
            {
                bool tim = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].get_name().Contains(ten) ){
                            list[i].ouput(i);
                            tim = true; }
                }
                if (!tim) { Console.WriteLine("Khong co hoc sinh {0} trong danh sach",ten); }
            }

        }// sua điểm chop hoc sinh
        public void suadiemchosinhvien()
        {
            if (list.Count == 0) Console.WriteLine("Danh sách chưa có sinh viên nào!");
            else
            {
                Console.Write("Nhập vào mã sinh viên cần sửa điểm: ");
                string masinhvien = Console.ReadLine();
                
                bool find = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].get_code() == masinhvien)
                    {
                        Console.WriteLine("Sinh viên: " + list[i].get_name());//xuất ra tên sinh viên
                        Console.WriteLine("Điểm hiện tại: " + list[i].get_mark());//xuất ra điểm hiện tại
                        Console.Write("Nhập vào điểm cần sửa: ");
                        
                        double diemmoi = Convert.ToDouble(Console.ReadLine());
                        list[i].set_mark(diemmoi);
                        Console.WriteLine("Đã sửa điểm cho sinh viên!");
                        find = true;
                        break;
                    }
                }
                if (!find) Console.WriteLine("Không tìm thấy sinh viên nào có mã số: " + masinhvien);
            }       
        }
        public void nhanhocbong()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ( list[i].get_mark() > 8) { Console.WriteLine("Hoc sinh ten {0} duoc nhan hoc bong",list[i].get_name()); }
                else Console.WriteLine("Hoc sinh ten {0} khong nhan hoc bong", list[i].get_name()); 
            }
            
        }


        // tìm sinh vien theo tên sinh viên
        public void timtheotensinhvien()
        {
            if (list.Count == 0) { Console.WriteLine("Danh sach chua co sinh vien nao!"); }
            else
            {
                Console.Write("Nhap ten hoc sinh ban muon  tim");
                string ten = Console.ReadLine();
                
                bool tim = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].get_name().Contains(ten))
                    {
                        list[i].ouput();
                        tim = true;
                    }
                }
                if (tim!) Console.WriteLine("khong tim thay hoc sinh ten {0} '",ten );
            }
        // tìm sinh vien theo mã số
        }public void timtheomasosinhvien()
        {
            if (list.Count == 0) { Console.WriteLine("Danh sach chua co hoc vien nao!"); }
            else
            {
                Console.Write("Nhap ma hoc vien ban muon tim: ");
                String ma = Console.ReadLine();
                
                bool tim = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i].get_code() == ma)
                    {
                        Console.WriteLine("sinh vien: " + list[i].get_name());// xuat ten sinh vien
                        Console.WriteLine("Diem sinh vien: " + list[i].get_mark());
                        tim = true;
                        
                    }
                }
                if (!tim) { Console.WriteLine("Ma sinh vien {0} khong co trong danh sach"); }
            }
        //sắp xếp giá ban giảm dần
        }public void danhsachgiamdantheoMark()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int index = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if(list[j].get_mark() > list[index].get_mark())
                    {
                        index = j;                        
                    }
                }
                strudent smallernumber = list[index];
                list[index] = list[i];
                list[i] = smallernumber;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0}", list[i]);
            }Console.ReadLine();
        }// sắp xếp theo giá bán , nếu bằng nhau thì xét tên
        public void sapxep()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int index = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].get_mark() > list[index].get_mark())
                    {
                        index = j;
                    }
                    strudent minmax = list[index];
                    list[index] = list[i];
                    list[i] = minmax;
                }
                    
                
            }
        }// sắp xếp theo giá bán , nếu bằng nhau thì xét tên
        public void sapxeptheodiem()
        {
            list.Sort(new SortByMark());
            System.Console.WriteLine("Danh sach da duoc sap xep theo diem.");
        }

        public void sapxeptheodiemvaten()
        {
            list.Sort(new SortByMarkandName());
            System.Console.WriteLine("Danh sach da duoc sap xep theo diem va ten.");
        }

    }
    
    
}
