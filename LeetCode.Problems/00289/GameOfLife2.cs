namespace LeetCode.Problems;

public class GameOfLife2{

    public void GameOfLife(int[][] board){

        int rows = board.Length;
        int cols = board[0].Length;

        for(int i = 0; i< rows; i++){
            for(int j=0; j< cols; j++){
                int currState = board[i][j];
                int count = Count(board,i,j,rows,cols);

                if(currState == 1 && (count<2 || count >3)){
                    board[i][j] = 2;
                }else if(currState == 0 && count == 3){
                    board[i][j] = -1;
                }
            }
        }

        for(int i=0; i<rows; i++){
            for(int j=0;j< cols; j++){
                if(board[i][j] == 2){
                    board[i][j] = 0;
                }else if (board[i][j] == -1){
                    board[i][j] = 1;
                }
            }
        }
        
    }

    private int Count(int[][] board, int row, int col, int rows, int cols){

        int count = 0;

        for(int i = row-1; i<= row+1;i++){
            for(int j = col-1; j< col+1; j++){
                if(i >=0 && j >=0 && i<rows&&  j< cols && !(i==row && j==col)){
                    if(board[i][j] == 1 || board[i][j]==2){
                        count++;
                    }
                }
            }
        }

        return count;
    }

}