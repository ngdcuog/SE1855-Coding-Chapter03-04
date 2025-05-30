using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FullTimeEmployee obama = new FullTimeEmployee()
{
    Id = 1,
    Name = "Balack Obama",
    IdCard = "0001",
    Birthday = new DateTime(1960, 1, 1)
};

Console.WriteLine("----------- OBAMA's Information -----------");
Console.WriteLine($"Id = {obama.Id}");
Console.WriteLine("Name = " +  obama.Name);
Console.WriteLine("IdCard = " + obama.IdCard);
Console.WriteLine("Ngày sinh: " + obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Mức lương obama nhận : " + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    Name = "Donut Trump",
    IdCard = "0002",
    Birthday = new DateTime(1965, 1, 1)
};
trump.WorkingHour = 5;
Console.WriteLine("----------- OBAMA's Information -----------");
Console.WriteLine($"Id = {trump.Id}");
Console.WriteLine("Name = " + trump.Name);
Console.WriteLine("IdCard = " + trump.IdCard);
Console.WriteLine("Ngày sinh: " + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Mức lương Trump nhận : " + trump.calSalary() + "\n");

Console.WriteLine("------------------ Sử dụng toString() ------------------");
Console.WriteLine(obama);
Console.WriteLine(trump);
