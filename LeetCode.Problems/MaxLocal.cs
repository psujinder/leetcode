namespace LeetCode.Problems;

public class MaxLocal {

    public int[,] MaxLocalGrid(int[][] grid){

        int len = grid.Count()-2;
        int[,] maxLocal = new int[len,len];

        for(int i = 0; i< len;i++){
              for(int j=0;j< len;j++){
                maxLocal[i,j] = CalculateMaxLocal(grid, i,j);
              }  
        }

        return maxLocal;
    }

    private int CalculateMaxLocal(int[][] grid, int i, int j){
        int x = i+1;
        int y = j+1;
        int maxLocalVal = 0;

        for(int a = x-1; a<=x+1;a++){
            for(int b = y-1; b<=y+1;b++){
                if (a >=0 && a < grid.Count() && b>=0 && b<grid.Count()){
                    maxLocalVal = Math.Max(maxLocalVal,grid[a][b]);
                }
            }
        }

        return maxLocalVal;
    }
}