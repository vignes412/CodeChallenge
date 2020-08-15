/*
 * @lc app=leetcode id=1480 lang=csharp
 *
 * [1480] Running Sum of 1d Array
 */

// @lc code=start
public class Solution {
    public int[] RunningSum(int[] nums) {
        int [] result =new int[nums.Length];
        int total=0;
        for(int i=0;i<nums.Length;i++){
            total+=nums[i];
            result[i]=total;
        }
        return result;
    }
}
// @lc code=end

