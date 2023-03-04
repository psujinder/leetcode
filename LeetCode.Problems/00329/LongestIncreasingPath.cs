namespace LeetCode.Problems;

public class LongestIncreasingPath_PR{

    public int LongestIncreasingPath(int[][] matrix) {
        
        if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0){
            return 0;
        }

        int rows = matrix.Length, cols = matrix[0].Length;
        int[,] dp = new int[rows,cols];

        int maxPath = 0;

        for(int i=0; i<rows; i++){
            for(int j=0; j<cols;j++){
                maxPath = Math.Max(maxPath, dfs(matrix, i,j,dp));
            }
        }

        return maxPath;
    }

    private int dfs(int[][] matrix, int i, int j, int[,] dp){

        //base case
        if(dp[i,j] > 0){
            return dp[i,j];
        }

        //explore 4 directions
        int maxPath = 0;
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[][] directions = new int[][]{
            new int[]{0,1},
            new int[]{1,0},
            new int[]{0,-1},
            new int[]{-1,0},
        };

        foreach(int[] direction in directions){
            int row = i + direction[0];
            int col = j + direction[1];
            if( row >=0 && row < rows && col >=0 && col < cols && matrix[row][col] > matrix[i][j]){
                maxPath = Math.Max(maxPath, 1+dfs(matrix,row,col,dp));
            }
        }

        dp[i,j] = maxPath;
        return maxPath;

    }

}