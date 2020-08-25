/*
 * @lc app=leetcode id=1342 lang=csharp
 *
 * [1342] Number of Steps to Reduce a Number to Zero
 */

// @lc code=start
public class Solution {
    public int NumberOfSteps (int num) {
        int steps =0 ;
        for(int i=0;num>0;i++){
            if(num%2==1){
                num-=1;
                steps++;
            }
            if(num==0)
                return steps;
            
            num/=2;
            steps++;
        }
        return steps; 
    }
}
// @lc code=end

