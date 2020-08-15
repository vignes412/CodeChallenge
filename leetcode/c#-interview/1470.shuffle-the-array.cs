using System;
/*
 * @lc app=leetcode id=1470 lang=csharp
 *
 * [1470] Shuffle the Array
 */

// @lc code=start
public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] arr=new int[nums.Length];
        int counter=0;
        for(int i=0;i<nums.Length;i+=2){
            arr[i]=nums[counter];
            arr[i+1]=nums[n+counter];
            counter++;
        }        
        return arr;
    }
}
// @lc code=end

