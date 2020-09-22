using System;

namespace TongCacPhanTuCheoTrongMaTran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("hay nhap so hang cua ma tran");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("hay nhap so cot cua ma tran");
            int col = int.Parse(Console.ReadLine());
            int[,] array = new int[row, col];
            Console.WriteLine("Nhap gia tri cua ma tran: {0} x {1}", row, col);
            for (int i = 0; i<row; i++)
            {
                for(int j = 0; j<col; j++)
                {
                    Console.WriteLine("Hay nhap gia tri phan tu vi tri {0}x{1}", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //tong hang ngoai
            int tong_hang = 0;
            for (int i=0; i<col;i++)
            {
                tong_hang += array[0, i] + array[row-1, i];

            }
            //tong cot ngoai
            int tong_cot = 0;
            for (int j = 0; j <row; j++)
            {
                tong_cot += array[j, 0] + array[j, col-1];
            }

            int ket_qua = tong_cot + tong_hang - array[0, 0] - array[0, col - 1] - array[row - 1, 0] - array[row - 1, col - 1];

            Console.WriteLine("tong vien ngoai ma tran so:{0}", ket_qua);


        }
    }
}
