using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class MaxConsectiveOne3
    {
        public static int Calculate(int[]  value,int k)
        {
            int maxLen = 0, l = 0, r = 0, zeroCount = 0;
            for(r = 0; r < value.Length; r++)
            {
                if (value[r] == 0) zeroCount++;
                while (zeroCount > k)
                {
                    if (value[l] == 0)
                    {
                        zeroCount--;
                    }
                    l++;
                }
                maxLen = Math.Max(maxLen, r - l + 1);
            }
            return maxLen;
        }
    }
}
