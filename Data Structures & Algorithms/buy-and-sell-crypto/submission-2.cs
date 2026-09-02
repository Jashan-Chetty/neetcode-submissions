public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0;
        int minPrice = prices[0];

        foreach(int sell in prices) {
            maxP = Math.Max(maxP, sell - minPrice);
            minPrice = Math.Min(minPrice, sell);
        }

        return maxP;
    }
}
