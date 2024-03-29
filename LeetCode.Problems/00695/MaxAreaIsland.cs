namespace LeetCode.Problems;

public class MaxAreaIsland{

    public int MaxAreaOfIsland(int[][] grid){

        int area = 0;
        bool[][] visited = new bool[grid.Length][];
        for(int i=0; i< grid.Length; i++){
            visited[i] = new bool[grid[i].Length];
        }

        for(int i=0 ; i < grid.Length; i++){
            for(int j=0; j < grid[0].Length; j++){
                if(grid[i][j] ==1 & visited[i][j] == false){
                   area = Math.Max(dfs (i,j, grid,visited), area);
                }
            }
        }

        return area;
    }

    private int dfs(int i, int j, int[][] grid, bool[][] visited){

            if(i <0 || i >= grid.Length || j <0 || j >= grid[0].Length || visited[i][j] == true || grid[i][j] == 0){
                return 0;
            }

            visited[i][j] = true;

            int d1 = dfs(i-1,j,grid,visited);
            int d2 = dfs(i+1,j,grid,visited);
            int d3 = dfs(i,j-1,grid,visited);
            int d4 = dfs(i,j+1,grid,visited);

            return 1 + d1 + d3 + d4 + d2;

    }

}