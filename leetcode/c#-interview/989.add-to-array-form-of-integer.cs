/*
 * @lc app=leetcode id=989 lang=csharp
 *
 * [989] Add to Array-Form of Integer
 */

// @lc code=start
public class Solution {
    public IList<int> AddToArrayForm(int[] A, int K) {
        int carry=0;
        string total;
        for(int i=A.Length-1;i>=0||K>0;i--){
            if(i>=0){
            int tot=A[i]+(K%10)+carry;
            carry = tot>=10?1:0;
            A[i]=tot%10;
            }else{
                carry= K+carry;
                break;
            }
            K/=10;
        }
        total=String.Join("",A);
        if(carry!=0){
           total=carry+String.Join("",A);
        }
        return total.ToCharArray().Select(x=>x-'0').ToList();
    }
}
// @lc code=end

