using System;

namespace NhapInMangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] array = new int[3, 3];
            for (int i= 0; i<3; i++)
            {
                for(int j =0; j < 3; j++)
                {
                    Console.WriteLine("nhap phan tu {0}x{1}", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("mang da chieu:");
            for (int i= 0; i<3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.WriteLine("gia tri phan tu {0}x{1}", i, j);
                    Console.WriteLine(array[i, j]);
                }
            }

        }
    }
}
