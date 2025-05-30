using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_ExtensionMethod
{
    public static class MyUtils
    {
        // câu 1 : hãy cài đặt 1 hàm TongTu1ToiN
        // vào kiểu int của MS

        public static int TongTu1ToiN(this int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        // câu 2: Viết hàm tính tổng 2 số 
        public static int Cong(this int a, int b)
        {
            return a + b;
        }


        // câu 3: săsp xếp tăng dần 1 mảbg kiểu int
        public static void SapXepTangDan(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        // câu 4: Viết hàm tu dong dien vao mang INT
        public static void TaoMang(this int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
            }
        }

        public static void XuatMang(this int[] arr)
        {
            for(int i = 0;i < arr.Length;i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }




    }
}
