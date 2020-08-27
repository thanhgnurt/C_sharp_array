using System;

namespace Exerise_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai tap mang bai 1");
            int[] array = new int[10];
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Hay nhap gia tri phan tu {0} :", i);
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Cac phan tu trong mang la:");
            for(int i=0; i<10; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
