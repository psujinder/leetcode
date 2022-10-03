namespace LeetCode.Problems;

public class NumerOfEnclaves{

    public int NumEnclaves(int[][] grid) {

        int i = 0;
        int j = 0;
        int count = 0;

        for(j=0; j< grid[0].Length; j++){
            if(grid[i][j] == 1){
                dfs(grid,i,j);
            }
        }

        i = grid.Length -1;
        for(j=0; j< grid[0].Length; j++){
            if(grid[i][j] == 1){
                dfs(grid,i,j);
            }
        }

        j=0;
        for(i=0; i< grid.Length; i++){
            if(grid[i][j] == 1){
                dfs(grid,i,j);
            }
        }

        j=0;
        for(i=0; i< grid[0].Length; i++){
            if(grid[i][j] == 1){
                dfs(grid,i,j);
            }
        }

        j=grid[0].Length-1;
        for(i = 0; i < grid.Length; i++){
            for(j=0; j<grid[i].Length; j++){
                if(grid[i][j]==1){
                    count++;
                }
            }
        }

        return count;
    } 

    private void dfs(int[][] grid, int i, int j){

        if(i < 0 || j < 0 || i > grid.Length || j > grid.Length || grid[i][j] == 0)
        {
            return;
        }
       
        if(grid[i][j] == 1){
            grid[i][j] = 0;
        }

        dfs(grid,i+1,j);
        dfs(grid,i-1,j);
        dfs(grid,i,j-1);
        dfs(grid,i,j+1);
    }

}