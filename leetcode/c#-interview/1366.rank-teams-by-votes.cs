/*
 * @lc app=leetcode id=1366 lang=csharp
 *
 * [1366] Rank Teams by Votes
 */

// @lc code=start
public class Solution {
    public string RankTeams(string[] votes) {
        Dictionary<char, double> teamScore = new Dictionary<char, double>();
            int n = votes[0].Length, power = 1000;
            foreach (string s in votes)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    char team = s[i];
                    if (teamScore.ContainsKey(team)) teamScore[team] += Math.Pow(power, n - i);
                    else teamScore[team] = Math.Pow(power, n - i);
                }
            }
            IEnumerable<char> cc = teamScore.Keys.OrderByDescending(x => teamScore[x]).ThenBy(x => x);
            return new string(cc.ToArray());
    }
}
// @lc code=end

