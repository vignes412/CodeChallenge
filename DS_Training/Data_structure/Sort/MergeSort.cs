using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class MergeSort
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
                int mid = (start + end) / 2;
                Sort(arr, start, mid);
                Sort(arr, mid+1, end);
                Merge(arr, start, mid+1, end);
            }
        }

        private static void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[right];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
