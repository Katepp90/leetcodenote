public class Solution {
    public int MaxProfit(int[] prices) {
       if(prices == null || prices.Length < 1) return 0;
       int maxEarn = 0;
       for(int i=0; i< prices.Length-1;i++)
       {
           if(prices[i] < prices[i+1]) maxEarn += prices[i+1] - prices[i];
       }
       return maxEarn;
    }
}