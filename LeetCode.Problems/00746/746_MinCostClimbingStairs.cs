namespace LeetCode.Problems;

public class MinCostStairs{


    public int MinCostClimbingStairs(int[] cost) {
        int[] minHealth = new int[cost.Length +1];

        for(int i = 2; i< minHealth.Length; i++){
            
            minHealth[i] = Math.Min(minHealth[i-1]+cost[i-1], minHealth[i-2]+cost[i-2]);
            
        }
        
        return minHealth[minHealth.Length-1];
    }
}