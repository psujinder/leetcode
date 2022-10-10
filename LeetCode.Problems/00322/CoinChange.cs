namespace LeetCode.Problems;

public class CoinChangeProblem{

    List<List<int>> results = new List<List<int>>();

    public int CoinChange(int[] coins, int amount) {
    
        if (amount < 1) return 0;
        return coinChange(coins, amount, new int[amount]);
    }

    private int coinChange(int[] coins, int rem, int[] count) {
        if (rem < 0) return -1;
        if (rem == 0) return 0;
        if (count[rem - 1] != 0) return count[rem - 1];
        int min = Int32.MaxValue;
        foreach(int coin in coins) {
            int res = coinChange(coins, rem - coin, count);
            if (res >= 0 && res < min)
                min = 1 + res;
        }
        count[rem - 1] = (min == Int32.MaxValue) ? -1 : min;
        return count[rem - 1];
  }

    

}