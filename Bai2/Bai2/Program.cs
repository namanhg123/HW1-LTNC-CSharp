using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Mang = ArrayProcessor.InputArray();
            Console.WriteLine("Mang vua nhap la: ");
            ArrayProcessor.DisplayArray(Mang);
            ArrayProcessor.BubbleSort((int[])Mang.Clone());
            Console.WriteLine("Quick Sort: ");
            ArrayProcessor.QuickSort((int[])Mang.Clone(), 0, Mang.Length - 1);
            Console.WriteLine("Nhap Key Linear Search: "); int key = int.Parse(Console.ReadLine());
            ArrayProcessor.LinearSearch((int[])Mang.Clone(), key);
            Console.WriteLine("Nhap Key Binary Search: "); key = int.Parse(Console.ReadLine());
            ArrayProcessor.LinearSearch(ArrayProcessor.BubbleSort(Mang), key);
        }
    }
}
