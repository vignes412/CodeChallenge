using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=937 lang=csharp
 *
 * [937] Reorder Data in Log Files
 */

// @lc code=start
public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        SortedList<string, string> let = new SortedList<string, string>();
        List<string> dig = new List<string>();
        List<string> res = new List<string>();
        for (int i = 0; i < logs.Length; i++)
        {
            if (logs[i][logs[i].IndexOf(" ")+1]>='a' &&
            logs[i][logs[i].IndexOf(" ")+1]<='z')
            {
                let.Add(logs[i].Substring(logs[i].IndexOf(" ")+1), logs[i]);
            }else {
                dig.Add(logs[i]);
            }
        }

        res.AddRange(let.Select(x => x.Value).ToList());
        res.AddRange(dig.Select(x => x).ToList());
        return res.ToArray();
    }
}
// @lc code=end

