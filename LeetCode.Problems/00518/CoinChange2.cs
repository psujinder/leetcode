namespace LeetCode.Problems;

public class CoinChange2Problem{

    List<IList<int>> results = new List<IList<int>>();

    public int CoinChange(int amount, int[] coins){

        int[] dp = new int[amount+1];
        Array.Fill(dp, 0);  
        dp[0] = 1;

       foreach(int coin in coins){
          for(int j=coin; j < amount; j++){
              dp[j] += dp[j-coin];
           }
       }

        return dp[amount];
    }
    
}