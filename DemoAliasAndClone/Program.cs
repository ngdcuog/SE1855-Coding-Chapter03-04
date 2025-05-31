using System.Text;
using DemoAliasAndClone;

Console.OutputEncoding = Encoding.UTF8;

Student s1 = new Student();
s1.Name = "Tèo";
s1.Id = 1;

Student s2 = new Student();
s2.Id = 2;
s2.Name = "Tí";

// Lức này trên thanh Ram sẽ cấp pháy 2 ô nhớ cho s1 và s2 quản lí 
// s1 đổi giá trị ko liên quam j tới s2 vì s1 và s2 quản lí 2 ô nhớ 

s1 = s2;
// ta viết lệnh s1 = s2 
// tuy nhiên về bản chất nó hạot động như sau 
// s1 trỏ tới vùng nhớ mà s2 quản lí chứ không phải s1 = s2 

// có 2 tình thuống xảy ra 
// TH1: ô nhứo bên s2 có thêm s2 quản lí =====> ALIAS có >= 2 đối tượng quản lí
// chỉ cần 1 đối tượng đổi thì các đối tượng khác đều bị đổi 

s2.Name = "Cuòng đẹp trai ";
Console.WriteLine("s2 đổi tên vậy s1 có tên là gì ");
Console.WriteLine(s1.Name);

// TH2: ô nhớ lúc trước s1 đg quản lý giờ ko còn đối tượng nào quản lý 
// lúc này HDDH tự động thu hồi ô hớ; Garbage Collection 
// tức là ta không thể truy xuất đẻ lấy lại giá trị s1.Id = 1 Name = Tèo 

