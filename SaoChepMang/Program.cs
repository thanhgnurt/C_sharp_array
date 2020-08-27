using System;

namespace SaoChepMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sao chep mang");
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            int i, n;
            Console.WriteLine("Hay nhap so phan tu trong mang:");
            n = int.Parse(Console.ReadLine());
            for(i=0; i< n; i++)
            {
                Console.WriteLine("Hay nhap phan tu thu {0}:", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            // sao chep mang
            for(i=0; i<n; i++)
            {
                array2[i] = array1[i];

            }

            // in phan tu trong mang 1
            Console.WriteLine("Cac phan tu trong mang 1 la:");
            for(i=0; i<n; i++)
            {
                Console.WriteLine("{0 }", array1[i]);

            }

            //in phan tu trong mang 2
            Console.WriteLine("Cac phan tu trong mang 2 la:");
            for(i=0; i<n; i++)
            {
                Console.WriteLine("{0 }", array2[i]);
            }



        }
    }
}
