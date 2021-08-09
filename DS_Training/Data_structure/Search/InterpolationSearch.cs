using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class InterpolationSearch
    {
        public static int Search(int[] arr, int start, int end,int value)
        {
            int pos;

            if(start<=end && arr[start]<=value && arr[end] >= value)
            {
                pos = start + (((value - arr[start])* (end - start)) / (arr[end] - arr[start]));

                if (arr[pos] == value)
                    return pos;
                if (arr[pos] < value)
                    return Search(arr, pos+1, end, value);
                if (arr[pos] > value)
                    return Search(arr, start, pos - 1, value);

            }
            return -1;
        }
    }
}
