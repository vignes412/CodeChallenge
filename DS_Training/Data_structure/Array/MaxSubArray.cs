using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class MaxSubArray
    {
        public static int MaxArray(int[] nums1,int[] nums2)
        {
            int count = 0;
            int max = 0;
            int startWith = 0;
            int i = 0, j = 0;
            while (i < nums1.Length)
            {
                if (j == nums2.Length)
                {
                    i++; 
                    j = 0;
                    max = Math.Max(max, count); 
                    count = 0;
                }
                else
                {
                    if (nums1[i] == nums2[j])
                    {
                        count++;
                        i++;
                    }
                    else if (count > 0)
                    {
                        j = 0;
                        startWith++;
                        max = Math.Max(max, count);
                        count = 0;
                        i = startWith;
                        continue;
                    }
                    j++;
                }
            }
            return Math.Max(max, count);
        }
        public static int findLength(int[] A, int[] B)
        {
            int ans = 0;
            int[,] memo = new int[A.Length + 1, B.Length + 1];
            for (int i = A.Length - 1; i >= 0; --i)
            {
                for (int j = B.Length - 1; j >= 0; --j)
                {
                    if (A[i] == B[j])
                    {
                        memo[i,j] = memo[i + 1,j + 1] + 1;
                        if (ans < memo[i,j]) ans = memo[i,j];
                    }
                }
            }
            return ans;
        }
        /*Console.WriteLine(JsonConvert.SerializeObject(MaxSubArray.findLength(
               JsonConvert.DeserializeObject<int[]>("[0,1,1,1,0]"), 
                JsonConvert.DeserializeObject<int[]>("[1, 1, 1, 1, 1]"))));
            Console.WriteLine(JsonConvert.SerializeObject(MaxSubArray.MaxArray(
                JsonConvert.DeserializeObject<int[]>("[0,0,0,0,1]"), 
                JsonConvert.DeserializeObject<int[]>("[1, 0, 0, 0, 0]"))));
            Console.WriteLine(JsonConvert.SerializeObject(MaxSubArray.findLength(
                JsonConvert.DeserializeObject<int[]>("[0,0,0,0,0,0,1,0,0,0]"), 
                JsonConvert.DeserializeObject<int[]>("[0, 0, 0, 0, 0, 0, 0, 1, 0, 0]"))));*/
        //public static int findLength2(int[] A, int[] B)
        //{
        //    //int ans = 0;
        //    //Dictionary<int, List<int>> Bstarts = new Dictionary<int,List<int>>();
        //    //for (int j = 0; j < B.Length; j++)
        //    //{
        //    //    Bstarts.get(B[j], x-> new List()).add(j);
        //    //}

        //    //for (int i = 0; i < A.Length; i++) if (Bstarts.containsKey(A[i]))
        //    //    {
        //    //        for (int j: Bstarts.get(A[i]))
        //    //        {
        //    //            int k = 0;
        //    //            while (i + k < A.Length && j + k < B.Length && A[i + k] == B[j + k])
        //    //            {
        //    //                k++;
        //    //            }
        //    //            ans = Math.max(ans, k);
        //    //        }
        //    //    }
        //    //return ans;
        //}
    }
}
