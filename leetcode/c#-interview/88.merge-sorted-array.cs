/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i=m,j=0;i<m+n&&j<n;i++,j++)
            nums1[i]=nums2[j];
        mergesort(nums1,0,m+n-1);
    }
    public void mergesort(int[] arr,int start,int end){
       if(start<end){
           int mid =(end+start)/2;
           mergesort(arr, start, mid);           
           mergesort(arr, mid+1,end);
           merge(arr,start ,mid,end);
       }
    }
    public void merge(int[] arr,int start,int mid,int end){
        int i=start,j=mid+1,k=0;
        int[] temp =new int[end-start+1];
        while(i<=mid&&j<=end)
        {
            if(arr[i]<=arr[j]){
                temp[k]=arr[i];
                i++;k++;
            }else{
                temp[k]=arr[j];
                j++;k++;
            }
        }
        
        while(i<=mid){
            temp[k]=arr[i];
            i++;k++;
        }
        while(j<=end){
            temp[k]=arr[j];
            j++;k++;
        }
        for(int m=start;m<=end;m++){
            arr[m]=temp[m-start];
        }
    }
}
// @lc code=end

