using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    internal class HinhCN : Hinh
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public override double TinhChuVi() => 2 * (ChieuDai + ChieuRong);
        public override double TinhDienTich() => ChieuDai * ChieuRong;
    }
}
