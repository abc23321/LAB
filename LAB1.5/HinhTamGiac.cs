﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    internal class HinhTamGiac : Hinh
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override double TinhChuVi() => A + B + C;

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
