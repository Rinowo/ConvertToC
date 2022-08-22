using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertC
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int i, j, tmp, n = 10;

            for(i = 0; i < n; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("Array after sort: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
