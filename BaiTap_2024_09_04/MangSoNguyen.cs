using System;
using System.Collections;
using System.Collections.Specialized;

namespace MangSoNguyen
{
    // từ khóa internal là cho phép cái class trong cùng 1 assembly(thư viện, dự án)
    internal class MangSoNguyen
    {
        public int[] arr;
        public int n; // số lượng phần tử của mảng


        // kiểm tra except khi nhập giá trị cho biến số lượng phần tử của mảng
        public static int  isValidValue()
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number of elements in the array: ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new Exception("Please enter a positive integer");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return n;

        } 
        public MangSoNguyen()
        {
        }

        public void inputArray()
        {
            n = isValidValue();
            arr = new int[n];
            Console.WriteLine("Enter integer array: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter value for element " + i + 1 + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void outputArray() 
        { 
            for(int i = 0; i < arr.Length;i++)
            {
                Console.Write(arr[i]+"\t");
            }
        }

        public void sumArray()
        {
            int sum = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                sum += arr[i];
            } 
            Console.WriteLine("The sum of elements in array: "+ sum);
        }

    }
}

