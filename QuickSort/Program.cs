using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 80, 40, 60, 20, 30, 90, 150, 50, 110, 70 };
            QuickSort(arr);
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void QuickSort(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }

        private static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int temp;
            int j = low;
            int pivotvalue = arr[high];
            for (int i = low; i < high; i++)
            {
                if (arr[i] < pivotvalue) // change comparison to '>' for descending sort
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j++;
                }
            }
            temp = arr[j];
            arr[j] = arr[high];
            arr[high] = temp;
            return (j);
        }
    }
}