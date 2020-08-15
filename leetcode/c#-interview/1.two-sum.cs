/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         var total=0;
    for(int i=1;i<nums.Length;i++){
        for(int j=0;j<i;j++){
            if(nums[j]+nums[i]==target){
                return new int[]{j,i};
            }
        }
    }
        return null;
    }
}
// @lc code=end

