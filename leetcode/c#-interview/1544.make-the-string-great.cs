/*
 * @lc app=leetcode id=1544 lang=csharp
 *
 * [1544] Make The String Great
 */

// @lc code=start
public class Solution {
     public string MakeGood(string s) {
       for(int i=0;i<s.Length-1;i++){
           if((Char.IsLower(s[i]) &&
            Char.IsUpper(s[i+1]) ||
            (Char.IsUpper(s[i]) &&  
            Char.IsLower(s[i+1])))&&
            Char.ToLower(s[i])==Char.ToLower(s[i+1])){
               Console.WriteLine(s.Remove(i,2));
              s=MakeGood(s.Remove(i,2));
           }
       }
       return s;
    }
}
// @lc code=end

