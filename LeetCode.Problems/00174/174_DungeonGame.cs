namespace LeetCode.Problems;
using System.Numerics;

public class DungeonGame{

    public int CalculateMinimumHP(int[][] dungeon){
        int[,] dp = new int[dungeon.Length, dungeon[0].Length];
        return CalculateHealth(0,0,dungeon, dp);
    }

    private int CalculateHealth(int x, int y, int[][] dungeon, int[,] dp){

        if(x == dungeon.Length-1 && y == dungeon[0].Length -1){
            return dungeon[x][y] > 0 ? 1 : Math.Abs(dungeon[x][y])+1;
        }

        if(dp[x,y] != 0)
            return dp[x,y];

        if (x == dungeon.Length -1){
            return  dp[x,y]= Math.Max(1, CalculateHealth(x, y+1, dungeon,dp)- dungeon[x][y]);
        }

        if (y == dungeon[0].Length -1){
            return  dp[x,y]=Math.Max(1, CalculateHealth(x+1, y, dungeon,dp)- dungeon[x][y]);

        }

        return  dp[x,y]= Math.Max(1, Math.Min(CalculateHealth(x+1, y, dungeon,dp) - dungeon[x][y], CalculateHealth(x,y+1,dungeon,dp)- dungeon[x][y]));

    }

}