public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = prices[0];

        foreach(int sell in prices) {
            maxProfit = Math.Max(maxProfit, sell - minPrice);
            minPrice = Math.Min(sell, minPrice);
        }

        return maxProfit;
    }
}
