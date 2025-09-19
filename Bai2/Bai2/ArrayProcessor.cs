using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class ArrayProcessor
    {
        public static int[] InputArray()
        {
            while (true)
            {
                int n;
                while (true)
                {
                    Console.Write("Vui long nhap so luong phan tu cua mang: ");
                    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    {
                        break;
                    }
                    Console.WriteLine("So luong phan tu khong hop le. Vui long nhap mot so nguyen duong.");
                }

                int[] arr = new int[n];
                Console.WriteLine("Nhap vao cac phan tu cua mang: ");

                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        Console.Write($"Nhap phan tu Mang[{i}]: ");
                        if (int.TryParse(Console.ReadLine(), out arr[i]))
                        {
                            break;
                        }
                        Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap mot so nguyen.");
                    }
                }
                return arr;
            }
        }
        public static void DisplayArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
        public static int[] BubbleSort(int[] arr)
        {
            Console.WriteLine("Bubble Sort: ");
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                Console.WriteLine(string.Join(" ", arr));
            }
            return arr;
        }
        public static void QuickSort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int pivot = arr[(left + right) / 2];
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
                Console.WriteLine(string.Join(" ", arr));
            }
            if (left < j)
            {
                QuickSort(arr, left, j);
            }
            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }
        public static void LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    Console.WriteLine($"Tim thay {key} tai vi tri {i} cua mang");
                    return;
                }
            }
            Console.WriteLine($"Khong tim thay {key} trong mang");
        }
        public static void BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key)
                {
                    Console.WriteLine($"Tim thay {key} tai vi tri {mid} cua mang");
                    return;
                }
                if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine($"Khong tim thay {key} trong mang");
        }
    }
}
