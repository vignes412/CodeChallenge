/*
 * @lc app=leetcode id=1528 lang=csharp
 *
 * [1528] Shuffle String
 */

// @lc code=start
public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] result=new char[indices.Length];
        for(int i =0;i<indices.Length;i++){
            result[indices[i]]=s[i];
        }
        return string.Join("",result);
    }
}
// @lc code=end

