namespace LeetCode.Problems;

public class BestTimeToBuyAndSellStock{

    public int MaxProfit(int[] prices){

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++){
            if(prices[i] < minPrice){
                minPrice = prices[i];
            }

            var tmpProfit = prices[i] - minPrice;
            maxProfit = (tmpProfit > maxProfit)? tmpProfit: maxProfit;
        }

        return maxProfit;

    }

}