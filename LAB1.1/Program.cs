//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//// Bài 1
//Console.Write("Nhập tên: ");
//string ten = Console.ReadLine();
//Console.Write("Nhập tuổi: ");
//int tuoi = int.Parse(Console.ReadLine());
//Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
//// Bài 2
//Console.Write("Nhập chiều dài: ");
//int dai = int.Parse(Console.ReadLine());
//Console.Write("Nhập chiều rộng: ");
//int rong = int.Parse(Console.ReadLine());
//int dientich = dai * rong;
//Console.WriteLine($"Diện tích: {dientich}");
//// Bài 3
//Console.Write("Nhập độ C: ");
//int c = int.Parse(Console.ReadLine());
//int f = (c * 9 / 5) + 32;
//Console.WriteLine($"Độ F: {f}");
//// Bài 4
//Console.Write("Nhập số nguyên: ");
//int so = int.Parse(Console.ReadLine());
//if (so % 2 == 0)
//    Console.WriteLine($"{so} là số chẵn.");
//else
//    Console.WriteLine($"{so} là số lẻ.");
//// Bài 5
//Console.Write("Nhập số thứ nhất: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Nhập số thứ hai: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"Tổng: {a + b}, Tích: {a * b}");
//// Bài 6
//Console.Write("Nhập một số: ");
//int x = int.Parse(Console.ReadLine());
//if (x > 0)
//    Console.WriteLine("Số dương.");
//else if (x < 0)
//    Console.WriteLine("Số âm.");
//else
//    Console.WriteLine("Số không.");
//// Bài 7
//Console.Write("Nhập năm: ");
//int nam = int.Parse(Console.ReadLine());
//if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
//    Console.WriteLine($"{nam} là năm nhuận.");
//else
//    Console.WriteLine($"{nam} không phải là năm nhuận.");
//// Bài 8
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"\nBảng cửu chương {i}:");
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i * j}");
//    }
//}
//// Bài 9
//Console.Write("Nhập số nguyên dương: ");
//int n = int.Parse(Console.ReadLine());
//long giaiThua = 1;
//for (int i = 1; i <= n; i++)
//{
//    giaiThua *= i;
//}
//Console.WriteLine($"{n}! = {giaiThua}");
//// Bài 10
//Console.Write("Nhập một số nguyên: ");
//int n2 = int.Parse(Console.ReadLine());
//if (n2 < 2)
//{
//    Console.WriteLine($"{n2} không phải là số nguyên tố.");
//}
//else
//{
//    bool laNguyenTo = true;
//    for (int i = 2; i <= Math.Sqrt(n2); i++)
//    {
//        if (n2 % i == 0)
//        {
//            laNguyenTo = false;
//            break;
//        }
//    }
//    if (laNguyenTo)
//        Console.WriteLine($"{n2} là số nguyên tố.");
//    else
//        Console.WriteLine($"{n2} không phải là số nguyên tố.");
//}
