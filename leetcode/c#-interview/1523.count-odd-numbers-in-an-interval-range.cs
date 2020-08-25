/*
 * @lc app=leetcode id=1523 lang=csharp
 *
 * [1523] Count Odd Numbers in an Interval Range
 */

// @lc code=start
public class Solution {
     public int CountOdds(int low, int high) {
        int oddLow=low%2==1?low:low+1;
        int oddHigh=high%2==1?high:high-1;
        return ((oddHigh-oddLow)/2 )+1;
    }
}
// @lc code=end

