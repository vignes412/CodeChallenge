/*
 * @lc app=leetcode id=1 lang=javascript
 *
 * [1] Two Sum
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    for(i=0;i<nums.length;i++){
        var correctValue=target-nums[i];
        for(j=i+1;j<nums.length;j++){
            if(nums[j]==correctValue){
                return [i,j];
            }
        }
    }
};
// @lc code=end

