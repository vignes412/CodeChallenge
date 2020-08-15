using System.Linq;
using System;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=771 lang=csharp
 *
 * [771] Jewels and Stones
 */

// @lc code=start
public class Solution {
    public int NumJewelsInStones(string J, string S) {
        if(J=="" || S=="")
            return 0;
        int total=0;
        for(int i =0;i<S.Length;i++){
            if(J.Contains(S[i])){
                total++;
            }
        }    
        return total;    
    }
}
// @lc code=end

