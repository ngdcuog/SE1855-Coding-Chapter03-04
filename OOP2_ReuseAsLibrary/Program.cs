// Hãy cài đạt 1 hàm tính tuổi và hàm EMployee nhưung không đc thay đổin code cũ 
using System.Text;
using OOP2;
using OOP2_ReuseAsLibrary;

Console.OutputEncoding = Encoding.UTF8;

FullTimeEmployee e1 = new FullTimeEmployee();

e1.Id = 1;
e1.Name = "Cường";
e1.IdCard = "000761";
e1.Birthday = new DateTime(2004, 7, 21);
Console.WriteLine("--------Thông tin của E1--------");
Console.WriteLine(e1);
Console.WriteLine("--- Tuổi của E1 là " + e1.calAge());