using System.Text;
using OOP3_ExtensionMethod;

Console.OutputEncoding = Encoding.UTF8;

int n = 5;

Console.WriteLine("Toỏng từ 1 tới 5 = " + n.TongTu1ToiN());

int m = 10;
Console.WriteLine("Tổng từ 1 tới 10 = " + m.TongTu1ToiN());
Console.WriteLine("Tổng từ 1 tới 100 = " + 100.TongTu1ToiN());

Console.WriteLine("Tổng của 5 và 10 là " + 5.Cong(10));

int[] arr = new int[5];

arr.TaoMang();
Console.WriteLine("Mang truoc khi sap xep");
arr.XuatMang();
arr.SapXepTangDan();
Console.WriteLine("Mang sau khi sap xep");
arr.XuatMang();
