using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure.Sort
{
    public static class Problems
    {
        public static string SortString(string s)
        {
            int[] counts = new int[26];
            foreach (var c in s)
            {
                counts[c - 'a']++;
            }

            StringBuilder sb = new StringBuilder(s.Length);
            int direction = 1;
            int idx = 0;

            while (sb.Length != s.Length)
            {
                if (idx == 26 || idx == -1)
                {
                    direction = -direction;
                    idx += direction;
                }

                if (counts[idx] > 0)
                {
                    counts[idx]--;
                    sb.Append((char)(idx + 'a'));
                }

                idx += direction;
            }

            return sb.ToString();
        }

        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int loadedBox = 0;
            var temp = boxTypes.OrderByDescending(x => x[1]).ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (truckSize != 0)
                {
                    loadedBox += temp[i][0] > truckSize ? truckSize * temp[i][1] : temp[i][0] * temp[i][1];
                    truckSize = temp[i][0] > truckSize ? 0 : truckSize - temp[i][0];
                }
            }
            return loadedBox;
        }
        public static int OnesCount(int n)
        {
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & (1 << i)) != 0)
                {
                    res++;
                }
            }

            return res;
        }
        public static int NumSubarrayBoundedMax(int[] A, int L, int R)
        {
            return NumSubarrayBoundedMax(A, R) - NumSubarrayBoundedMax(A, L - 1);
        }

        private static int NumSubarrayBoundedMax(int[] A, int max)
        {
            int result = 0, previous = -1;
            for (int i = 0; i <= A.Length; i++)
            {
                if (i == A.Length || A[i] > max)
                {
                    int length = i - previous - 1;
                    result += (length * (length + 1)) / 2;
                    previous = i;
                }
            }

            return result;
        }
    }
}
