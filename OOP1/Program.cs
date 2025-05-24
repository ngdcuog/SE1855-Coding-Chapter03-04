using System.Text;
using OOP1;

Console.OutputEncoding = Encoding.UTF8;

//  Tạo 1 đối tượng danh mục
Category c1 = new Category();
// Gán giá trị cho các thuộc tính này 
c1.Id = 1;
c1.Name = "Nước mắm";
// Gọi hàm xuất dữ liệu 
c1.PrintInfor();

// Khởi tạo nhân viên 
Employee e1= new Employee();
e1.Id = 00001;
e1.Name = "Nguyen Duong Cuong";
e1.Id_Card = "064204000761";
e1.Email = "cuong@gmail.com";
e1.Phone = "0764023678";

e1.PrintInfor();
Console.WriteLine("---------------------");
Console.WriteLine("Id của e1 = " + e1.Id);
Console.WriteLine($"Name của e1 = {e1.Name}");

// Ta cũng có thể khởi tạo đối tượng và giá trị của các thuộc tính như sau 
Employee e2 = new Employee()
{
    Id = 2,
    Id_Card = "0640643064",
    Name = "Nguyen Luong Hoang Vu",
    Email = "vu@gmail.com",
    Phone = "0987654312"
};

Console.WriteLine("-----------E2----------");
e2.PrintInfor();


Console.WriteLine("===================");
Employee e3 = new Employee(3, "123213", "Bang", "bang@gmaik.com", "012321321");
// goi ham xuat 
e3.PrintInfor();
// nhap tu dong goi toString 
Console.WriteLine(e3);

Employee e4 = new Employee();
Console.WriteLine(e4);


// Tao doi tuong CUstomer
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Nguyen THi Lung Linh",
    Email = "lunglinh@gmail.com",
    Phone = "000012",
    Address = "36 Hoang Van Thu"
};

cus1.PrintInfor();
cus1.Address = "Nguyen Sy Sach phuong 15 quan Tan Binh";
Console.WriteLine("Thong tin cua Cust2 sau khi chinh sua");
cus1.PrintInfor();