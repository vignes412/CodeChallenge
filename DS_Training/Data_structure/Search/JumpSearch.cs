using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class JumpSearch
    {
        public static int Search(int[] arr, int value, int length)
        {
            int prev=0,step = (int)Math.Sqrt(length);

            while (arr[Math.Min(step,length)-1]<value)
            {
                prev = step;
                step += (int)Math.Sqrt(length);
                if (prev >= length)
                    return -1;
            }

            while (arr[prev]<value)
            {
                prev++;

                if(prev == Math.Min(step, length))
                {
                    return -1;
                }
            }
            if(arr[prev]==length)
                return prev;

            return -1;
        }
    }
}
