/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        int aLength=a.Length-1;
        int bLength=b.Length-1;
        int carry=0;
        string total="";
        while(aLength>=0||bLength>=0||carry!=0){
            int v1=0,v2=0;
            if(aLength>=0){
              v1=(a[aLength]-'0');  
            }
             if(bLength>=0){
              v2=(b[bLength]-'0');  
            }
            int tot=v1+v2+carry;
            total = (tot%2)+total;
            carry=tot/2;
            aLength--;
            bLength--;
        }
        return total;
    }
}
// @lc code=end

