/*
 * @lc app=leetcode id=1518 lang=csharp
 *
 * [1518] Water Bottles
 */

// @lc code=start
public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var total=numBottles;
       while(numBottles/numExchange!=0){
           total=total+(numBottles/numExchange);
           numBottles=(numBottles/numExchange)+numBottles%numExchange;
       }
        return total;
    }
}
// @lc code=end

