using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class QuickSort
    {
        public static void Sort(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            Sort(arr, start, end);
        }

        private static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int loc = Partition(arr, start, end);
                Sort(arr, start, loc - 1);
                Sort(arr, loc + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int key = arr[end];
            int low = start - 1;
            for(int i = start; i <= end-1; i++)
            {
                if (arr[i] < key)
                {
                    low++;
                    Swap(arr,low,i);
                }
            }
            Swap(arr, low+1, end);
            return low + 1;
        }

        private static void Swap(int[] arr, int low, int i)
        {
            int temp = arr[low];
            arr[low] = arr[i];
            arr[i] = temp;
        }
    }
}
