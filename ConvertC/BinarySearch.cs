using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertC
{
    internal class BinarySearch
    {
        static void Main(string[] strings)
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int low = 0, high = 9, mid;

            int giaTri, timThay = 0;

            Console.WriteLine("Nhap 1 gia tri: ");
            giaTri = Console.Read();

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (arr[mid] == giaTri)
                {
                    Console.WriteLine("Gia tri " + giaTri + "duoc tim thay o vi tri " + mid + " cua mang");
                    timThay = 1;
                    break;
                } if(arr[mid] > giaTri)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            if (timThay == 0)
            {
                Console.WriteLine("Gia tri " + giaTri + " khong duoc tim thay trong mang");
            }
        }
    }
}
