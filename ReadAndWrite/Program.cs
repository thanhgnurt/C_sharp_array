using System;

namespace ReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[10];
            for (int i=0;i<10; i++)
            {
                Console.WriteLine("hay nhap gia trin thu : {0}", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Gia tri cua mang vua tao la:");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
