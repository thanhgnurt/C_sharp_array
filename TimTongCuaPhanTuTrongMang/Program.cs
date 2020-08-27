using System;
using System.Text;

namespace TimTongCuaPhanTuTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Tinh tong trong mang");
            int[] array = new int[10];
            int result = 0;
            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine("Hay nhap phan tu thu {0} trong mang:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0; i<10; i++)
            {
                result += array[i];
            }
            Console.WriteLine("Tong cua cac phan tu trong mang nay la: {0}", result);
        }
    }
}
