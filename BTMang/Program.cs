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
        //Bài 305(*): Tìm dãy con toàn dương có tổng lớn nhất
        static int IndexEndChildSequence(int[] array)
        {
            int sumMax = 0;
            int sum = 0;
            int indexPre = -1;
            //index cuoi day duong lon nhat
            int indexResult = -1;

            for (int i = 0; i<array.Length; i++)
            {
                if (array[i]>=0 )
                {
                    sum += array[i];
                    indexPre = i;

                }
                if (indexPre < i || i == array.Length - 1)
                {
                    if (sumMax < sum)
                    {
                        sumMax = sum;
                        indexResult = indexPre;
                    }
                    sum = 0;
                }
                
            }
            return indexResult;
        }
        //Bài 304(*): Cho mảng a, số nguyên M. Tìm 1 mảng con sao cho tổng các phần tử bằng M
        static int SoSanhM(int[] array, int M, bool first)
        {
            for (int i = array.Length-1; i<0; i--)
            {
                if (array[i]<M)
                {
                    return i;
                }
                if (!first && array[i]==M)
                {
                    return -2;

                }
                
            }
            return -1;
        }
        static int[] TimMangConCoTongM(int[] array,int[] arrayResult, int M)
        {

            for (int i= 1; i<=array.Length; i++)
            {


            }
            return arrayResult;
     
        }
        static int[] Child_FindArraySumEvenM(int[] A, int M, int n)
        {
            int[] arrayChild = new int[n];
            for (int i = 0; i<=A.Length-n; i++)
            {
                
                    int index = 0;
                    for (int j= i; j<n+i; j++)
                    {
                        arrayChild[index] = j;
                        index++;
                      
                    }
                    int sumArray = TinhTongArrayResult(A, arrayChild);
                    if (sumArray==M)
                    {
                        return arrayChild;
                    } else
                    {
                        arrayChild = ResetArrayResult(arrayChild);
                    }
                
            }
            return arrayChild;

        }

        static void FindArraySumEvenM(int[] A, int M)
        {
            int[] newArray;
            bool flag = false;
            for (int i =1; i<=A.Length; i++)
            {
                newArray = Child_FindArraySumEvenM(A, M, i);
                if (newArray[0]>=0)
                {
                    flag = true;
                    Console.WriteLine("Mang con bang M:");
                    HamInMang(newArray);
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Khong Tim thay mang con nao bang M");
            }


        }


        //bai 304 tinh tong cua day ket qua
        static int TinhTongArrayResult(int[] A, int[] arrayResult)
        {
            int sum = 0;
            for(int i=0; i<arrayResult.Length; i++)
            {
                int index = arrayResult[i];
                if (index >= 0)
                {
                    sum += A[index];
                }
                else sum=0;
            }
            return sum;

        }

        // tim vi tri luu cuoi cung cua day ket qua
        static int IndexArrayResult(int[] arrayResult)
        {
            for (int i = 0; i< arrayResult.Length; i++)
            {
                if (arrayResult[i]==-1)
                {
                    return i-1;
                }
            }
            return -1;
        }
        //reset array result
        static int[] ResetArrayResult(int[] arrayResult)
        {
            for (int i=0; i<arrayResult.Length; i++)
            {
                arrayResult[i] = -1;
            }
            return arrayResult;

        }

        //Bài 173 (*): Cho mảng 1 chiều các số nguyên. Hãy  viết hàm tìm chữ số xuất hiện ít nhất trong mảng
        static int[] ArrayTimes(int[] A)
        {
            int[] array_times = new int[A.Length];
            for (int i = 0; i< A.Length; i++)
            {
                int count = 0;
                for (int j = 0; j< A.Length; j++)
                {
                    if (A[i]==A[j])
                    {
                        count++;
                    }
                }
                // push times into array_times
                array_times[i] = count;
            }
            return array_times;
        }

        static void TimSoXuatHienItNhat(int[] A)
        {
            int[] array_times = ArrayTimes(A);
            int index_min = TimMin(array_times);
            Console.WriteLine("So xuat hien it nhat trong mang la:");
            for (int i=0; i<array_times.Length; i++)
            {
                if (array_times[i] == array_times[index_min])
                {
                    bool flag = true;
                    for (int j=0; j<i; j++)
                    {
                        if (A[i]==A[j])
                        {
                            flag = false;
                        }
                     
                    }
                    if (flag)
                    {
                        Console.WriteLine(A[i]);

                    }
                }
            }

        }

        //ham nhap mang
        static int[] NhapMang()
        {
            Console.WriteLine("Hay nhap tong so phan tu trong mang:");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i< A.Length; i++)
            {
                Console.WriteLine("Hay nhap phan tu mang thu [{0}]", i);
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A= NhapMang();
            //122 tim max trong mang
            //Console.WriteLine(TimMax(array));
            //TimViTriMin(array);
            //HamInMang(array);
            //HamInMang(SapXepMangTangDan(array));
            //int index = IndexEndChildSequence(array);
            //Console.WriteLine(index);
            int[] arrayResult = new int[A.Length];
            for (int i = 0; i<arrayResult.Length; i++)
            {
                arrayResult[i] = -1;
            }

            //FindArraySumEvenM(A, 15);
            TimSoXuatHienItNhat(A);



           // HamInMang(FindIndexStartArrayChild(A, 5, 15));

        }
    }
}
