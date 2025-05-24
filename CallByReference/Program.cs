using System.Text;

void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");

}

Console.OutputEncoding = Encoding.UTF8;
int n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham1(n);
Console.WriteLine($"n truoc sau vao ham = {n}");

void ham2(ref int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");

}
Console.WriteLine("------------------REF----------------");
n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham2(ref n);
Console.WriteLine($"n truoc sau vao ham = {n}");

//ref Phải khởi taoj giá trị cho biến trc khi gọi 
//int m;
//ham2(ref  m); // báo lỗi dòng m vì m chưa có giá trị 

void ham3(out int n)
{
    n = 8;

}


