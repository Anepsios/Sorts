using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 80, 40, 85, 15, 65, 45, 95, 75, 35, 55, 60, 20, 30, 90, 25, 50, 110, 70 };
            BucketSort(arr);
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void BucketSort(int[] arr)
        {
            List<int>[] buckets = new List<int>[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int bucket = arr[i] / arr.Length;
                buckets[bucket].Add(arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                buckets[i].Sort();
                buckets[i].Reverse(); //for descending
            }

            int index = 0;
            for (int i = arr.Length - 1; i >= 0; i--) // descending
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index++] = buckets[i][j];
                }
            }
        }
    }
}
