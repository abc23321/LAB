using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    internal class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }
        public void Nhap()
        {
            Console.Write("Tử số: ");
            Tu = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Mẫu số (khác 0): ");
                Mau = int.Parse(Console.ReadLine());
            } while (Mau == 0);
        }
        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tuMoi = a.Tu * b.Mau + b.Tu * a.Mau;
            int mauMoi = a.Mau * b.Mau;
            return RutGon(new PhanSo { Tu = tuMoi, Mau = mauMoi });
        }
        public static PhanSo RutGon(PhanSo ps)
        {
            int ucln = UCLN(Math.Abs(ps.Tu), Math.Abs(ps.Mau));
            ps.Tu /= ucln;
            ps.Mau /= ucln;
            return ps;
        }
        public static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        public void HienThi()
        {
            Console.WriteLine($"{Tu}/{Mau}");
        }

    }
}
