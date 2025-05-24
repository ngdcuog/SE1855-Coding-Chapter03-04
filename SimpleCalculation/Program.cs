// See https://aka.ms/new-console-template for more information

using System.Text;
Console.OutputEncoding = Encoding.UTF8;

void  do_calculate(double a, double b, string op)
{
    switch(op)
    {
        case "+":
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            break;
        case "-": 
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            break;
        default:
            Console.WriteLine("Nhập sai toán tử + - * / rồi !!!!!");
            break;
    }
}

Console.WriteLine("SIMPLE CALCULATION!!");
Console.WriteLine("Nhập số a: ");
double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập số b: ");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập toán tử + - * / :");
string op = Console.ReadLine();

do_calculate(a, b, op);
Console.ReadLine();
