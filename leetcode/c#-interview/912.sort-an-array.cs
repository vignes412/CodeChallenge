/*
 * @lc app=leetcode id=912 lang=csharp
 *
 * [912] Sort an Array
 */

// @lc code=start
public class Solution {
   public int[] SortArray(int[] nums)
        {
            var arr = nums;
            //QuickSort(arr);
            MergeSort(arr,0,arr.Length-1);
            return arr;
        }
        #region merge sort
        public void MergeSort(int[] nums,int start,int end){
            if(start<end){
                var mid = (end+start)/2;
                MergeSort(nums,start,mid);
                MergeSort(nums,mid+1,end);
                Merge(nums,start,mid,end);
            }
        }
        public void Merge(int[] nums, int start,int mid,int end){
            int[] temp=new int[end-start+1];
            int i=start,j=mid+1,k=0;
            while(i<=mid && j<=end){
                if(nums[i]<=nums[j]){
                    temp[k]=nums[i];
                    k++;i++;
                }else{
                    temp[k]=nums[j];
                    k++;j++;
                }
            }
            while(i<=mid){
                temp[k]=nums[i];
                k++;i++;
            }
            while(j<=end){
                temp[k]=nums[j];
                k++;j++;
            }
            for(int m=start;m<=end;m++)
                nums[m]=temp[m-start];
        }
        #endregion
        #region quickSort
        public void QuickSort(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            QuickSort(nums, start, end);
        }
        public void QuickSort(int[] nums, int start, int end)
        {
            if (start < end)
            {
                int part = Partition(nums, start, end);
                QuickSort(nums, start, part - 1);
                QuickSort(nums, part + 1, end);

            }
        }
        public int Partition(int[] nums, int start, int end)
        {
            int pivot = nums[end];
            int low = (start - 1);
            for (int i = start; i < end; i++)
            {
                if (nums[i] < pivot)
                {
                    low++;
                    int temp = nums[low];
                    nums[low] = nums[i];
                    nums[i] = temp;
                }
            }
            int temp1 = nums[low + 1];
            nums[low + 1] = nums[end];
            nums[end] = temp1;
            return low + 1;
        }
        #endregion
}
// @lc code=end

