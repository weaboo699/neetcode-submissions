public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int sell = prices[0];
        int bestProfit = 0;

        for(int i = 0; i < (prices.Length); i++){
            if(prices[i] > sell){
                sell = prices[i];
                if((sell - buy) > bestProfit){
                    bestProfit = (sell - buy);
                }
            }
            else if(prices[i] < buy){
                buy = prices[i];
                sell = prices[i];
            }
        }

        return bestProfit;
    }
}
