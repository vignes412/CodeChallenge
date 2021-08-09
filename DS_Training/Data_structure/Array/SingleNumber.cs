using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class SingleNumber
    {
        public static int solution(int[] nums)
        {
            HashSet<int> counter = new HashSet<int>(nums);
            return counter.Sum() * 2 - new List<int>(nums).Sum();
        }
    }
}
