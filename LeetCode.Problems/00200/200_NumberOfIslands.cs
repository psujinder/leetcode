namespace LeetCode.Problems;

public class NumberOfIslands{

    public int NumIslands(char[][] grid) {
        
       int islands = 0;

        for(int x = 0; x < grid.Length; x++){
            for(int y = 0; y < grid[0].Length; y++){
                if (grid[x][y] == '1'){
                    islands++;
                    dfs(grid, x, y);
                }        
            }
        }
        return islands;
    }
    
    private void dfs(char[][] grid, int x, int y){

        if(x < 0 || y <0 || x >= grid.Length || y>= grid[0].Length || grid[x][y] == '0'){
            return;
        }

        grid[x][y] = '0';
        dfs(grid, x+1, y);
        dfs(grid, x-1, y);
        dfs(grid, x, y+1);
        dfs(grid, x, y-1);
    }
}
