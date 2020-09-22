using System;

namespace BaiTapOnline
{
    class Program
    {
        static int[] Nhap_Mang()
        {
            Console.WriteLine("Nhap gia tri mang:");
            int[] Array = new int[5];
            for (int i=0; i<Array.Length; i++)
            {
                Console.WriteLine("Nhap Array[{0}]: ", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            return Array;


        }
        static int Tim_GTLN(int[] A)
        {
            int max = A[0];
            for (int i=1; i<A.Length; i++)
            {
                if (max< A[i]) {
                    max = A[i];
                }
            }

            return max;
        }

        static int TimTongGiaTriAm(int[] A)
        {
            int sum = 0;
            for(int i=0; i<A.Length; i++)
            {
                if (A[i] < 0)
                {
                    sum += A[i];
                }
            }
            return sum;
        }
        static int TimViTriSoChanDauTien(int[] A)
        {
           
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]%2==0)
                {
                    return i;
                }
            }
            return -1;
        }
        static bool KiemTraSoNguyenTo(int n)
        {
            

            return true;
            
        }

        static int TimSoNguyenToCuoi(int[] A)
        {
            for (int i = A.Length; i>-1; i--)
            {
                if (KiemTraSoNguyenTo(A[i]))
                {
                    return A[i];
                }

            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] Array = Nhap_Mang();

        }
    }
}
