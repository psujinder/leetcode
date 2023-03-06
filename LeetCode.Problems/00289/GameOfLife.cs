namespace LeetCode.Problems;

public class GameOfLife_PR{

    public void GameOfLife(int[][] board) {
        
        int rows = board.Count();
        int cols = board[0].Count();

        int[][] board_copy = new int[rows][];

        for(int i=0; i< rows; i++){
            board_copy[i] = new int[cols];
           board[i].CopyTo(board_copy[i],0);
        }

        for(int i=0; i < rows; i++){
            for(int j=0; j< cols;j++){
                
                int currCell = board_copy[i][j];

                int sum = 0;

                if(i-1>=0)
                    sum += board_copy[i-1][j];

                if(i+1<rows)
                    sum += board_copy[i+1][j];

                if(j-1>=0)
                    sum += board_copy[i][j-1];

                if(j+1<cols)
                    sum += board_copy[i][j+1];       

                if(i-1 >=0 && j-1 >=0){
                    sum += board_copy[i-1][j-1];
                }    

                if(i-1 >=0 && j+1 < cols){
                    sum += board_copy[i-1][j+1];
                }   

                if(i+1 <rows && j-1 >=0){
                    sum += board_copy[i+1][j-1];
                }

                if(i+1 <rows && j+1 < cols){
                    sum += board_copy[i+1][j+1];
                }

                if (currCell == 1){
                    if (sum < 2){
                        board[i][j] = 0;
                    }else if (sum == 2 || sum == 3){
                        board[i][j] = 1;
                    }else if (sum >3){
                        board[i][j] = 0;
                    }
                }else{
                    if (sum == 3){
                        board[i][j] = 1;
                    }
                }
            }       
        }

    }

}