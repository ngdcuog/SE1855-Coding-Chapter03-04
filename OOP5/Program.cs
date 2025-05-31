using System.Text;
using OOP5;

Console.OutputEncoding = Encoding.UTF8;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước ngọt";


Product p1 = new Product();
p1.Id = 1;
p1.Name = "Coca";
p1.Quantity = 10;
p1.Price = 12;
c1.AddProduct(p1);


Product p2 = new Product();
p2.Id = 2;
p2.Name = "Pépi";
p2.Quantity = 24;
p2.Price = 12;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "String";
p3.Quantity = 48;
p3.Price = 12;
c1.AddProduct(p3);

Product p4 = new Product(); 
p4.Id = 4;
p4.Name = "Redbul";
p4.Quantity = 24;
p4.Price = 15;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "Sprite";
p5.Quantity  = 30;
p5.Price = 10;
c1.AddProduct(p5);

// xuất toàn bộ sản phẩm của danh mục nước ngọt 
Console.WriteLine("-------- All Product of Category Soft Drink : ----------");
c1.PrintAllProduct();

Dictionary<int, Product> filters = c1.FilterProductsByPrice(15, 20);
Console.WriteLine("-- All Product have price from 15 -> 20:");
foreach(KeyValuePair<int, Product> kvp in filters)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}


Dictionary<int, Product> sort_result = c1.SortProductByPrice();
Console.WriteLine("-- List of Product have price asc by price :");
foreach (KeyValuePair<int, Product> kvp in sort_result)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_result2 = c1.SortProductByPriceAscThenQuantityDesc();
Console.WriteLine("-- List of Product have price asc by price then des by quantity:");
foreach (KeyValuePair<int, Product> kvp in sort_result2)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p1.Name = "Xá xị";
p1.Quantity = 30;
p1.Price = 8;
c1.UpdateProduct(p1);
Console.WriteLine("Sản phẩm sau khi chỉnh sửa ");
c1.PrintAllProduct();

int id = 3;
bool ret = c1.DeleteProduct(id);
if(ret)
{
    Console.WriteLine($"Đã xóa sản phẩm có mã {id} thành công");
    Console.WriteLine("--- Sản phẩm sau khi xóa ---");
    c1.PrintAllProduct();
} else
{
    Console.WriteLine($"Ko tìm thấy sản phẩm có mã {id} để xóa");
}


Category c2  = new Category();
c2.Id = 2;
c2.Name = "Beer";
c2.AddProduct(new Product() {Id = 6, Name = "Tiger", Price = 18, Quantity = 50});
c2.AddProduct(new Product() { Id = 7, Name = "1664", Price = 20, Quantity = 30});
c2.AddProduct(new Product() { Id = 8, Name = "Ken", Price = 25, Quantity = 100});


LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c1);
ss.AddLast(c2);

Console.WriteLine("---- Toàn bộ dữ liệu theo danh mục ----");
foreach (Category c in ss)
{
    Console.WriteLine($"--- {c.Name} ---");
    Console.WriteLine("**************************");
    c.PrintAllProduct();
    Console.WriteLine("**************************");
}

