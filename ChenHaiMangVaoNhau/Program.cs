using System;

namespace ChenHaiMangVaoNhau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chen hai mang");
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            int[] array3 = new int[100];
            int s1, s2, s3, i;
            Console.WriteLine("Hay nhap so luong phan tu trong mang 1 :");
            s1 = int.Parse(Console.ReadLine());
            for(i=0; i<s1; i++)
            {
                Console.WriteLine("hay nhap gia tri phan tu thu {0}", i);
                array1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Hay nhap so luong phan tu trong mang 2 :");
            s2 = int.Parse(Console.ReadLine());
            for (i = 0; i < s2; i++)
            {
                Console.WriteLine("hay nhap gia tri phan tu thu {0}", i);
                array2[i] = int.Parse(Console.ReadLine());

            }

            s3 = s1 + s2;

            for(i=0; i<s1; i++)
            {
                array3[i] = array1[i];
            }
            int j = s1;
            for (i=0; i<s2; i++)
            {
                
                array3[j] = array2[i];
                j++;

            }

            for(i=0; i<s3; i++)
            {
                Console.WriteLine(array3[i]);
            }






        }
    }
}
