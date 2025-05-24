using System.Text;

void swap(ref int a, ref int b)
{
    int tmp = a;
    a = b;
    b = tmp;
}

void sort_arr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i],ref arr[j]);
            }
        }
    }
}
void sort_arr_use_while(int[] arr)
{
    int i = 0; int j = i + 1;
    while(i < arr.Length)
    {
        while(j < arr.Length)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
        j = i + 1;
    }
}


void sort_arr_use_do_while(int[] arr)
{
    int i = 0; int j = i + 1;
    do
    {
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while (j < arr.Length);
        i++; j = i + 1;
    } while (i < arr.Length - 1);
}

void create_arr(int[] arr)
{
    Random rd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(100);
    }
}

void print_array(int[]arr)
{
    foreach (int i in arr)
    {
        Console.Write($"{i}\t");
    }
}

int[] arr = new int[10];
create_arr(arr);
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("------------------ Sử dụng For------------------");
Console.WriteLine("Mảng trước khi sắp xếp: ");
print_array(arr);
Console.WriteLine();
sort_arr_use_do_while(arr);
Console.WriteLine("Mảng sau khi sắp xếp: ");
Console.WriteLine();
print_array(arr);
Console.WriteLine();

Console.WriteLine("------------------ Sử dụng While ------------------");
