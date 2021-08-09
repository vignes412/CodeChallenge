using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class Rotate
    {
        public static void BruteForce(int[]  a,int k) {
            k %= a.Length;
            int pre = 0,temp=0;
            for(int i = 0; i < k; i++)
            {
                pre = a[a.Length - 1];
                for(int j = 0; j < a.Length; j++)
                {
                    temp = a[j];
                    a[j] = pre;
                    pre = temp;
                }
            }
        }
        public static void ExtraArray(int[]  a ,int k)
        {
            int[] b = new int[a.Length];
            for(int i = 0; i < a.Length; i++)
            {
                b[(i + k) % a.Length] = a[i];
            }
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = b[i];
            }
        }
        public static void CyclicReplacement (int[] a, int k)
        {
            k = k % a.Length;
            int count = 0;
            for(int start = 0; count < a.Length; start++)
            {
                int current = start;
                int prev = a[start];
                do
                {
                    int next = (current + k) % a.Length;
                    int temp = a[next];
                    a[next] = prev;
                    prev = temp;
                    current = next;
                    count++;
                } while (start != current);
            }
        }
    }
}
