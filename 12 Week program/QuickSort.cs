using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Week_program
{
    public class QuickSortAlgo
    {
        public int[] SortArray(int[] nums)
        {
            var arr = nums;
            QuickSort(arr);
            return arr;
        }
        public void QuickSort(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            QuickSort(nums, start, end);
        }
        public void QuickSort(int[] nums, int start, int end)
        {
            if (start < end)
            {
                int part = Partition(nums, start, end);
                QuickSort(nums, start, part - 1);
                QuickSort(nums, part + 1, end);

            }
        }
        public int Partition(int[] nums, int start, int end)
        {
            int pivot = nums[end];
            int low = (start - 1);
            for (int i = start; i < end; i++)
            {
                if (nums[i] < pivot)
                {
                    low++;
                    int temp = nums[low];
                    nums[low] = nums[i];
                    nums[i] = temp;
                }
            }
            int temp1 = nums[low + 1];
            nums[low + 1] = nums[end];
            nums[end] = temp1;
            return start + 1;
        }
    }
}
