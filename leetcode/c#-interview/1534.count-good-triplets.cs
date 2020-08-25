/*
 * @lc app=leetcode id=1534 lang=csharp
 *
 * [1534] Count Good Triplets
 */

// @lc code=start
public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int x=0;
        int i,j,k;
        for(i=0;i<arr.Length;i++){
            for(j=i+1;j<arr.Length;j++){
                for(k=j+1;k<arr.Length;k++){
                    if(Math.Abs(arr[i]-arr[j])<=a &&
                      Math.Abs(arr[j]-arr[k])<=b &&
                      Math.Abs(arr[i]-arr[k])<=c){
                        x++;
                    }
                }
            }
        }
        return x;
    }
}
// @lc code=end

