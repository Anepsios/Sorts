using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 80, 40, 60, 20, 30, 90, 150, 50, 110, 70 };
            BubbleSort(arr);
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void BubbleSort(int[] arr)
        {
            bool swapped;
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1]) // change comparison to "<" for descending
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
