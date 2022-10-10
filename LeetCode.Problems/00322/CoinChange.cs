namespace LeetCode.Problems;

public class CoinChangeProblem{

    List<List<int>> results = new List<List<int>>();

    public int CoinChange(int[] coins, int amount) {
    
        if(coins == null || coins.Length ==0) 
            return 0;
    
        int [] dp = new int[amount+1];
        Array.Fill(dp, Int32.MaxValue);
        dp[0] = 0;

        foreach(int coin in coins){
            for(int i=1; i < amount+1; i++){
                if(coin <= i && dp[i-coin] != Int32.MaxValue && dp[i-coin]+1 < dp[i]){
                    dp[i] = dp[i-coin]+1;
                }
            }
        }

        if(dp[amount]==Int32.MaxValue)
            return -1;
        return dp[amount];
        
    }

    

}