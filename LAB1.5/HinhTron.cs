using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    internal class HinhTron : Hinh
    {
        public double BanKinh { get; set; }
        public override double TinhChuVi() => 2 * Math.PI * BanKinh;
        public override double TinhDienTich() => Math.PI * BanKinh * BanKinh;
    }
}
