using System;

namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("nhap vao ho va ten: ");
            string chuoi = Console.ReadLine();
            for (int i = 0; i < chuoi.Length; i++)
            {
                if ((chuoi[i] >= '0' && chuoi[i] <= '9') || (chuoi[i] >= 'a' && chuoi[i] <= 'z') || (chuoi[i] >= 'A' && chuoi[i] <= 'Z'))
                {
                    chuoi = chuoi.Trim();

                }
                else Console.Write("ban nhap dang la ki tu dac biet. moi nhap lai: ");
                
                while (chuoi.IndexOf("  ") != -1 || chuoi.IndexOf("") != -1)
                {
                    chuoi = chuoi.Replace("  ", " ");
                }

            }
            string result= "";
            string[] fullname = chuoi.Split(' ');
            for (int i = 0; i < fullname.Length; i++)
            {
                string fisrtname = fullname[i].Substring(0, 1);
                string othername = fullname[i].Substring(1);
                fullname[i] = fisrtname.ToUpper() + othername.ToLower();
                result += fullname[i] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
