using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public class BinarySearch
    {
        public static int count = 0;
        public static int Search(int[] arr, int start, int end, int key)
        {
            count++;
            if (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (mid==end || arr[mid] == key || start==end)
                    return mid;

                if (arr[mid] > key)
                {
                    return Search(arr, start, mid - 1, key);
                }

                return Search(arr, mid + 1, end, key);
            }
            return -1;
        }
        public static int IterativeSearch(int[] arr, int start,int end, int key)
        {
            count++;
            if (start <= end)
            {
                int mid = 0;
                while (arr[mid] != key)
                {
                    mid = start + (end - start) / 2;
                    if (arr[mid] > key)
                    {
                        end = mid - 1;
                        continue;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                if (arr[mid] == key)
                    return mid;
            }
                return -1;
        }
    }
}
