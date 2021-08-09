using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class PairInSortedArray
    {
        public static int pairsInSortedRotated(int[] arr,
                                int length, int x)
        {
            int i,smallest,largest=0,count=0;
            for (i = 0; i < length; i++)
                if (arr[i] > arr[i + 1])
                    break;

            smallest = (i + 1) % length;

            largest = i;
            while(smallest != largest)
            {
                if (arr[smallest] + arr[largest] == x)
                {
                    count++;
                    if (smallest == (largest - 1 + length) % length)
                    {
                        return count;
                    }
                    largest = (largest - 1 + length) % length;
                    smallest = (smallest + 1) % length;
                }
                else if (arr[smallest] + arr[largest] > x)
                    largest = (largest - 1 + length) % length;
                else if (arr[smallest] + arr[largest] < x)
                    smallest = (smallest + 1) % length;
            }
            return count;
        }
    }
}
