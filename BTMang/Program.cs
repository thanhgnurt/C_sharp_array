using System;

namespace BTMang
{
    class Program
    {
        //ham in mang
        static void HamInMang(int[] array)
        {
            Console.WriteLine("Gia tri mang la:");
            for (int i =0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
                Console.WriteLine();
            }

        }
        //ham kiem tra so nguyen to
        static bool KiemTraSoNguyeTo(int n)
        {
            if(n <=1)
            {
                return false;
            }
            if (n==2 || n ==3)
            {
                return true;
            }
            if (n > 3)
            {
                for (int i = 2; i <= n/2; i++)
                {
                    if (n%i==0)
                    {
                        return false;
                    }


                }
            }
            return true;
           
        }
        //ham kiem tra gia tri chan trong mang co nho hon 2004 hay khong
        static bool KiemTraChanNhoHon2004(int[] arr)
        {
            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i]%2==0 && arr[i]<2004)
                {
                    return true;

                }
            }
            return false;

        }

        //ham tim vi tri nho nhat trong mang
        static void TimViTriMin(int[] array)
        {
            int min = TimMin(array);
            Console.WriteLine("Vi tri gia tri nho nhat trong mang:");
            for (int i= 0; i<array.Length; i++)
            {
                if (array[i]==min)
                {
                    Console.WriteLine(i);
                }

            }



        }
        //ham tim gia tri lon nhat trong mang
        static int TimMax(int[] Arr)
        {
            int max = Arr[0];
            for (int i =0; i<Arr.Length; i++)
            {
                if (max<Arr[i])
                {
                    max = Arr[i];
                }
            }
            return max;

        }
        //ham tim gia tri nho nhat trong mang
        static int TimMin(int[] Arr)
        {
            int min = Arr[0];
            int index = 0;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (min > Arr[i])
                {
                    min = Arr[i];
                    index = i;
                    
                }
            }
            return index;
        }
        //Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng
        static int DemTrue(int[] array)
        {
            int count = 0;
            for (int i=0; i<array.Length; i++)
            {
                if (KiemTraSoNguyeTo(array[i]) && array[i]<100)
                {
                    count++;
                }
            }

            return count;
        }
        //Bài 126: Viết hàm tính tổng các giá trị âm trong mảng 1 chiều các số thực
        static int TongSoAmTrongMang(int[] array)
        {
            int count = 0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i]<0)
                {
                    count++;
                }

            }
            return count;
        }
        // tim min custom
        static int TimMinCustom(int[] array, int start)
        {
            int min = array[start];
            int index = start;
            for (int i = start+1; i<array.Length; i++)
            {
                if (min>array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        //Bài 127: Viết hàm sắp xếp mảng 1 chiều các số thực tăng dần
        static int[] SapXepMangTangDan(int[] array)
        {
            int indexMin = 0;
            int temp;
            for(int i = 0; i<array.Length; i++)
            {
                indexMin = TimMinCustom(array, i);
                temp = array[i];
                array[i] = array[indexMin];
                array[indexMin] = temp;
            }

            return array;
        }
        // Ham tri tuyet doi
        static float TriTuyetDoi(float x)
        {
            if (x < 0)
            {
                x = -x;
            }
            return x;
        }
        //Bài 155: Hãy tìm giá trị trong mảng các số thực xa giá trị x nhất

        static int TimGiaTriTrongMangXaXNhat(float[] array, float x)
        {
            int indexMax = 0;
            
            for(int i= 1; i<array.Length; i++)
            {
         
                if (TriTuyetDoi(array[indexMax]-x)< TriTuyetDoi(array[i]-x))
                {
                    indexMax = i;
                }
            }

            return indexMax;
        }
        //Bài 169 (*): Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm số chẵn nhỏ nhất lớn hơn mọi giá trị có trong mảng
        static int TimSoChanMinLonHonMang(int[] array)
        {
            if (TimMax(array)%2==0)
            {
                return (TimMax(array) + 2);
            } else
            {
                return (TimMax(array) + 1);
            }
        }
        //Bài 150: Hãy tìm giá trị âm lớn nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị âm thì trả về  -1
        static float TimGiaTriAmMax(float[] array)
        {
            int maxAm = -1;
            for (int i = 0; i< array.Length; i++)
            {
                if(array[i]< 0 && maxAm == -1)
                {
                    maxAm = i;
                }
                if (array[i]<0 && maxAm!=-1 && array[maxAm]<array[i])
                {
                    maxAm = i;
                }
            }
            return maxAm;
        }

        //ham nhap mang
        static int[] NhapMang()
        {
            Console.WriteLine("Hay nhap tong so phan tu trong mang:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i< array.Length; i++)
            {
                Console.WriteLine("Hay nhap phan tu mang thu [{0}]", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = NhapMang();
            //122 tim max trong mang
            //Console.WriteLine(TimMax(array));
            //TimViTriMin(array);
            HamInMang(array);
            HamInMang(SapXepMangTangDan(array));
            

        }
    }
}
