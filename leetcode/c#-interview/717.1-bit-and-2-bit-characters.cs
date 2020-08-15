/*
 * @lc app=leetcode id=717 lang=csharp
 *
 * [717] 1-bit and 2-bit Characters
 */

// @lc code=start
public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        for(int i=0;i<bits.Length;i++){
           if(bits[i] == 1)
		{
			i++;
		}

		else if(i == bits.Length - 1)
		{
			return true;
		}
	}

	return false;
    }
}
// @lc code=end

