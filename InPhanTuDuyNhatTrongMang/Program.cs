using System;

namespace InPhanTuDuyNhatTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In phan tu duy nhat trong mang");
            int n, i,j, kiemTra;
            int[] array = new int[100];
            Console.WriteLine("Hay nhap so luong phan tu trong mang:");
            n = int.Parse(Console.ReadLine());
            for(i=0; i<n; i++)
            {
                Console.WriteLine("Hay nhap phan tu thu {0}", i);
                array[i] = int.Parse(Console.ReadLine());

               
            }

            Console.WriteLine("cac phan tu duy nhat trong mang");
            for(i=0; i < n; i++)
            {
                kiemTra = 0;
                for(j=0; j<n; j++)
                {
                    if (array[i]==array[j])
                    {
                        kiemTra += 1;
                        

                    }
                    
                }
                
                if (kiemTra == 1)
                {
                    Console.WriteLine(array[i]);

                }
            }

            
        }
    }
}
