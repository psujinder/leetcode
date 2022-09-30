namespace LeetCode.Problems;

public class BestTimeToBuyAndSellStock{

    public int MaxProfit(int[] prices){

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++){
            if(prices[i] < minPrice){
                minPrice = prices[i];
            }

            maxProfit = Math.Max(prices[i] - minPrice, maxProfit);
        }

        return maxProfit;

    }

}