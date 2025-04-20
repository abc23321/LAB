using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    internal class HinhCN : Hinh
    {
        public float ChieuDai { get; set; }
        public float ChieuRong { get; set; }
        public override float TinhChuVi() => 2 * (ChieuDai + ChieuRong);
        public override float TinhDienTich() => ChieuDai * ChieuRong;
    }
}
