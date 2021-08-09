using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class ArrayHelper
    {
        public static void Swap(int[] arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = arr[i];
        }
    }
}
