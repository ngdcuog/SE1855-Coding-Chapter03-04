using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

/* Sử dụng generic để quản lý nhân sự 
 * thựuc hiện đầy đủ các tính năng CRUD
 * C - Create - thêm nhân sự 
 * R - Read/Retrieve - Đọc truy vấn tìm kiểm sắp xếp 
 * U - Update - Chỉnh sửa dữ liệu 
 * D - Delete - Xóa dữ liêu 
 */ 

// Câu 1 CREATE
// DŨng list để tạo 5 Employee trong đó 4 Emplyee là chính thức và 1 Emp là thời vụ

List<Employee> employees = new List<Employee>();
FullTimeEmployee e1 = new FullTimeEmployee();
e1.Id = 1;
e1.Name = "Name1";
e1.IdCard = "IdCard1";
e1.Birthday = new DateTime(2004, 1, 1);
employees.Add(e1);

FullTimeEmployee e2 = new FullTimeEmployee();
e2.Id = 2;
e2.Name = "Name2";
e2.IdCard = "IdCard2";
e2.Birthday = new DateTime(2004, 2, 2);
employees.Add(e2);

FullTimeEmployee e3 = new FullTimeEmployee();
e3.Id = 3;
e3.Name = "Name3";
e3.IdCard = "IdCard3";
e3.Birthday = new DateTime(2004, 3, 3);
employees.Add(e3);


FullTimeEmployee e4 = new FullTimeEmployee();
e4.Id = 4;
e4.Name = "Name2";
e4.IdCard = "IdCard2";
e4.Birthday = new DateTime(2004, 4, 4);
employees.Add(e4);

ParttimeEmployee e5 = new ParttimeEmployee();
e5.Id = 5;
e5.Name = "Name5";
e5.IdCard = "IdCard5";
e5.Birthday = new DateTime(2004, 5, 5);
e5.WorkingHour = 5;
employees.Add(e5);


// Câu 2 R - Xuất toàn bộ nhân sự 
// cách xuất 1
Console.WriteLine("-------------- Danh sách nhân sự (C1) ---------------");
employees.ForEach(e => Console.WriteLine(e));
Console.WriteLine("-------------- Danh sách nhân sự (C2) ---------------");
foreach (var e in employees) {Console.WriteLine(e);}

// Câu 3 R -> Lọc ra nhân sự chính thức và tính tổng lương 
double sumSalary = 0;
Console.WriteLine("-------------- Danh sách nhân sự chính thức ---------------");
List<FullTimeEmployee> fullTimeEmployees = employees.OfType<FullTimeEmployee>().ToList();
fullTimeEmployees.ForEach(e => Console.WriteLine(e));

Console.WriteLine("-------------- Danh sách nhân sự chính thức Cách 2 ---------------");
// Cách 2 : thông thường 
List<FullTimeEmployee> list2 = new List<FullTimeEmployee>();
foreach (var e in employees)
{
    if(e is FullTimeEmployee)
    {
        list2.Add(e as FullTimeEmployee);
        //sumSalary += e.calSalary();
    }
}
list2.ForEach(e => Console.WriteLine(e));

sumSalary = list2.Sum(e => e.calSalary());
Console.WriteLine("Tổng lương của tất cả nhân sự chính thức : " + sumSalary);
Console.WriteLine();
// Câu 4 sắp xếp toàn bộ nhân sự theo năm sinh tăng dần 
for(int i = 0; i < employees.Count; i++)
{
    for(int j = i + 1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday > ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }

    }
}
Console.WriteLine("Danh sách nhân sự sau khi sắp xếp năm sinh tăng dần ");
employees.ForEach(e => Console.WriteLine(e));

// câu 5 sửa thông tin nhân viên
Console.WriteLine("------------------ Cập nhật thông tin nhân viên ------------------");
Console.Write("Nhập id nhân viên cần cập nhật: ");
int updateId = int.Parse(Console.ReadLine());

Employee empToUpdate = employees.FirstOrDefault(e => e.Id == updateId);
if(empToUpdate != null)
{
    Console.Write("Nhập tên cần cập nhật: ");
    empToUpdate.Name = Console.ReadLine();

    Console.Write("Nhập IDCard cần cập nhật: ");
    empToUpdate.IdCard = Console.ReadLine();

    Console.Write("Nhập Birthday cần cập nhật: (yyyy-MM-dd)");
    String birthdayInput = Console.ReadLine();
    DateTime birthday;
    if(DateTime.TryParse(birthdayInput, out birthday))
    {
        empToUpdate.Birthday = birthday;
    } else
    {
        Console.WriteLine("Ngày sinh không hợp lệ");
    }

    Console.WriteLine("Cập nhật thông tin thành công. Thông tin mới:");
    Console.WriteLine(empToUpdate);
}


// câu 6 Xóa thông tin nhân viên 
Console.WriteLine("------------------ Xóa thông tin nhân viên ------------------");
Console.Write("Nhập id nhân viên cần xóa: ");
int deleteId = int.Parse(Console.ReadLine());

Employee empToDelete = employees.FirstOrDefault(e => e.Id == deleteId);
if (empToDelete != null)
{
    employees.Remove(empToDelete);
    Console.WriteLine("Xóa nhân viên thành công\n Danh sách nhân viên sau khi xóa");
    employees.ForEach(e => Console.WriteLine(e));
}
else
{
    Console.WriteLine("Không tìm thấy nhân viên với Id tương ứng!!!");
}