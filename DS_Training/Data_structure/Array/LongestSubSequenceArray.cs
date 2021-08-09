using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static  class LongestSubSequenceArray
    {

        public static int LengthOfLIS2(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return 0;

            int[] dp = new int[nums.Length];
            dp[0] = 1;
            int max = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }

                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}
