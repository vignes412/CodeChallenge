/*
 * @lc app=leetcode id=415 lang=csharp
 *
 * [415] Add Strings
 */

// @lc code=start
public class Solution {
    public string AddStrings(string num1, string num2) {
        int n1Length=num1.Length-1;
        int n2Length=num2.Length-1;
        int carry=0;
        List<string> total=new List<string>();
        while(n1Length>=0||n2Length>=0||carry!=0){
            int v1=0;
            int v2=0;
            if(n1Length>=0){
                v1=(num1[n1Length]-'0');
            }
            if(n2Length>=0){
                v2=(num2[n2Length]-'0');
            }
            int totalin=v1+v2+carry;
            carry=totalin>=10?1:0;
            total.Add((totalin%10).ToString());
            n1Length--;
            n2Length--;            
        }
        return String.Join("",total.ToArray().Reverse());
    }
}
// @lc code=end

