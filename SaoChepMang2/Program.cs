using System;

namespace SaoChepMang2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sao chep mang");
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            Console.WriteLine("Hay nhap so phan tu co trong mang :");
            int n = int.Parse(Console.ReadLine());
            for (int i= 0; i<n; i++)
            {
                Console.WriteLine("Phan tu thu {0} trong mang :", i+1);
                array1[i] = int.Parse(Console.ReadLine());

            }
            //sao chep qua mang 2
            for (int i = 0; i<n; i++)
            {
                array2[i] = array1[i];

            }
            Console.WriteLine(array1.Length);

            Console.WriteLine("cac phan tu trong mang dau la");
            for (int i =0; i<n; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine("Cac phan tu trong mang sau la:");
            for (int i =0; i<n; i++)
            {
                Console.WriteLine(array2[i]);
            }

        }
    }
}
