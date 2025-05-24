using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n = -1;

while (n < 0)
{
    Console.Write("Nhập n >= 0: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out n))
    {
        if (n >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Nhập số lớn hơn hoặc bằng 0!");
        }
    }
    else
    {
        Console.WriteLine("Vui lòng nhập số nguyên!");
    }
}

int gt = 1;
for (int i = 1; i <= n; i++)
{
    gt *= i;
}

Console.WriteLine($"{n}! = {gt}");
