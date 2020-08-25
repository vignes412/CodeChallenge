/*
 * @lc app=leetcode id=1539 lang=csharp
 *
 * [1539] Kth Missing Positive Number
 */

// @lc code=start
public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int count=0;
        for(int i=1; i<10000;i++){
            if(!arr.Contains(i))
                count++;
            if(k==count)
                return i;
        }
        return 0;
    }
}
// @lc code=end

