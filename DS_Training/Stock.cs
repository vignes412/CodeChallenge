using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training
{
    public static class Stock
    {
        public static int MaxProfit(int[] prices, int fee)
        {

            var n = prices.Length;
            if (n == 0 || n == 1)
                return 0;
            var dp = new int[n + 1, 2];
            dp[0, 0] = 0;
            dp[0, 1] = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i - 1]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i - 1] - fee);
            }

            return dp[n, 0];
        }
        
       
    }
}
