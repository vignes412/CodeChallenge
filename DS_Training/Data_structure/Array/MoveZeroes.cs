using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure.Array
{
    public static class MoveZeroes
    {
        public static void SubOptimal(int[] nums)
        {
            int leadingNoZeroPostion = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[leadingNoZeroPostion++] = nums[i];
            }
            for (int i = leadingNoZeroPostion; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
        public static void Optimal(int[] nums)
        {
            for (int leadingNoZeroPostion = 0, cur = 0; cur < nums.Length; cur++)
            {
                if (nums[cur] != 0)
                {
                    int temp = nums[cur];
                    nums[cur] = nums[leadingNoZeroPostion];
                    nums[leadingNoZeroPostion] = temp;
                    leadingNoZeroPostion++;
                }
            }
        }
    }
}
