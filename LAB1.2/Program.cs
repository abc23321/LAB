//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
////bài 1
//static int TongSoChan(int[] arr)
//{
//    int tong = 0;
//    foreach (int so in arr)
//    {
//        if (so % 2 == 0)
//            tong += so;
//    }
//    return tong;
//}
//Console.Write("Nhập số lượng phần tử của mảng: ");
//int n = int.Parse(Console.ReadLine());
//int[] mang = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Nhập phần tử thứ {i + 1}: ");
//    mang[i] = int.Parse(Console.ReadLine());
//}

//int tongChan = TongSoChan(mang);
//Console.WriteLine($"Tổng các số chẵn trong mảng là: {tongChan}");
////bài 2
//static bool LaSoNguyenTo(int n)
//{
//    if (n < 2) return false;
//    for (int i = 2; i <= Math.Sqrt(n); i++)
//        if (n % i == 0)
//            return false;
//    return true;
//}
//Console.Write("Nhập số phần tử của mảng: ");
//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//for (int i = 0; i < n; i++)
//{
//     Console.Write($"Nhập phần tử thứ {i}: ");
//     arr[i] = int.Parse(Console.ReadLine());
//}
// Console.WriteLine("Các số nguyên tố trong mảng:");
//for (int i = 0; i < n; i++)
//{
//     if (LaSoNguyenTo(arr[i]))
//     {
//         Console.WriteLine($"Chỉ số: {i}, Giá trị: {arr[i]}");
//     }
//}
////bài 3
//Console.Write("Nhập số phần tử: ");
//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];

//int duong = 0, am = 0;

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Nhập phần tử thứ {i}: ");
//    arr[i] = int.Parse(Console.ReadLine());

//    if (arr[i] > 0) duong++;
//    else if (arr[i] < 0) am++;
//}
//Console.WriteLine($"Số dương: {duong} \nSố âm: {am}");
////bài 4
//Console.Write("Nhập số phần tử: ");
//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Nhập phần tử thứ {i}: ");
//    arr[i] = int.Parse(Console.ReadLine());
//}
//int max1 = int.MinValue, max2 = int.MinValue;
//foreach (int x in arr)
//{
//    if (x > max1)
//    {
//        max2 = max1;
//        max1 = x;
//    }
//    else if (x > max2 && x != max1)
//    {
//        max2 = x;
//    }
//}
//if (max2 == int.MinValue)
//    Console.WriteLine("Không tồn tại số lớn thứ hai.");
//else
//    Console.WriteLine($"Số lớn thứ hai là: {max2}");
////bài 5
//static void HoanVi(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//Console.Write("Nhập số a: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Nhập số b: ");
//int b = int.Parse(Console.ReadLine());
//HoanVi(ref a, ref b);
//Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
////bài 6
//Console.Write("Nhập số phần tử: ");
//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Nhập phần tử thứ {i}: ");
//    arr[i] = int.Parse(Console.ReadLine());
//}
//Array.Sort(arr);
//Console.WriteLine("Mảng sau khi sắp xếp:");
//foreach (var x in arr)
//{
//    Console.Write($"{x} ");
//}