namespace LeetCode.Problems;

public class NumberOfClosedIslands{

    public int ClosedIsland(int[][] grid) {
        
        int result = 0;

        for(int i=0; i< grid.Length; i++){
            for(int j=0; j < grid[0].Length; j++){
                if(grid[i][j] == 0){
                    if (dfs(grid, i, j)){
                        result ++;
                    }
                }
            }
        }

        return result;

    } 

    private bool dfs(int[][] grid, int i, int j){

            if(i < 0  || i >= grid.Length || j < 0 || j >= grid[0].Length){
                return false;
            }

            if(grid[i][j] == 1){
                return true;
            }

            grid[i][j] = 1;

            bool d1 = dfs(grid,i+1,j);
            bool d2 = dfs(grid,i-1,j);
            bool d3 = dfs(grid,i,j+1);
            bool d4 = dfs(grid,i,j-1);

            return d1 && d2 && d3 && d4;
    }

}