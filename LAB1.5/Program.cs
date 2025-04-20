using System.Text;
using LAB1._5;
Console.OutputEncoding = Encoding.UTF8;
////bài 1
//Console.Write("Nhập số lượng phân số: ");
//int n = int.Parse(Console.ReadLine());

//List<PhanSo> danhSach = new List<PhanSo>();

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine($"Phân số thứ {i + 1}:");
//    PhanSo ps = new PhanSo();
//    ps.Nhap();
//    danhSach.Add(ps);
//}

//PhanSo tong = danhSach[0];
//for (int i = 1; i < danhSach.Count; i++)
//{
//    tong = PhanSo.Cong(tong, danhSach[i]);
//}

//Console.Write("Tổng các phân số là: ");
//tong.HienThi();
////bài 2
//List<Hinh> danhSachHinh = new List<Hinh>();
//danhSachHinh.Add(new HinhTron { BanKinh = 5 });
//danhSachHinh.Add(new HinhVuong { Canh = 4 });
//danhSachHinh.Add(new HinhCN { ChieuDai = 4, ChieuRong = 2 });
//danhSachHinh.Add(new HinhTamGiac { A = 3, B = 4, C = 5 });
//double tongChuVi = 0;
//double tongDienTich = 0;
//foreach (Hinh h in danhSachHinh)
//{
//    tongChuVi += h.TinhChuVi();
//    tongDienTich += h.TinhDienTich();
//}

//Console.WriteLine($"Tổng chu vi các hình: {tongChuVi:F2}");
//Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");