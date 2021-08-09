using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class TwoSums
    {
        public static int[] DictionaryOptimal(int[] nums,int target)
        {
            Dictionary<int, int> t = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int comp = target - nums[i];
                if (t.ContainsKey(comp))
                    return new int[] { t[comp], i };
                t.Add(nums[i], i);
            }
            return new int[] { 0 };
        }
    }
}
