using System;

namespace TimSoPhanTuGiongNhau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tim kiem trong mang");
            int[] array = new int[100];
            int n, i,j, dem;
            Console.WriteLine("Hay nhap so luong phan tu duoc luu trong mang");
            n = int.Parse(Console.ReadLine());
            for(i=0; i<n; i++)
            {
                Console.WriteLine("Hay nhap phan tu thu {0}", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            // tim kiem phan tu giong nhau trong mang

            for(i=0; i<n; i++)
            {
                dem = 0;
                for (j=0; j<n; j++)
                {
                    if (array[i]==array[j])
                    {
                        dem += 1;
                    }
                }
                Console.WriteLine("so phan tu giong voi phan tu {0} la: {1}", array[i], dem);
            }

        }
    }
}
