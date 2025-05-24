using System.Text;
namespace FullStructorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tao muốn pass PRN SWP SWT SWR WDU");

            Console.WriteLine("Các đối số của bạn");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}]: {args[i]}");
            }

            Console.ReadLine();
        }
    }
}