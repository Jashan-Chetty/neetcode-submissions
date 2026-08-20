public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int currentPrice = prices[0];

        foreach(int sell in prices) {
            maxProfit = Math.Max(maxProfit, sell - currentPrice );
            currentPrice = Math.Min(currentPrice, sell);
        }
                return maxProfit;
    }
}
