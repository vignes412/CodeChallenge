/*
 * @lc app=leetcode id=1431 lang=csharp
 *
 * [1431] Kids With the Greatest Number of Candies
 */

// @lc code=start
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int[] dp=new int [candies.Length];
        int top=0;
        for(int i =0;i<candies.Length;i++){
            top=top<candies[i]?candies[i]:top;
            dp[i]=candies[i]+extraCandies;
        }
        bool[] result=new bool[candies.Length];
        for(int i=0;i<candies.Length;i++){
                result[i]=top<=dp[i];
        }
        return result;
    }
}
// @lc code=end

