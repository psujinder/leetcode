namespace LeetCode.Problems;

public class ValidSudoku{

    public bool IsValidSudoku(char[][] board) {
        
        bool[,] rows = new bool[board.Length+1, board[0].Length+1];
        bool[,] cols = new bool[board.Length+1, board[0].Length+1];
        bool[,] boxes = new bool[board.Length+1, board[0].Length+1];

        for(int i=0; i<board.Length; i++){
            for(int j=0;j<board[0].Length; j++){
                if(board[i][j] != '.'){
                    int val = board[i][j] - '0';    
                    int boxid = (i/3)*3 + j/3;

                    if(rows[i,val]){
                        return false;
                    }else{
                        rows[i,val] = true;
                    }

                    if(cols[j,val]){
                        return false;
                    }else{
                        cols[j,val] = true;
                    }

                    if(boxes[boxid,val]){
                        return false;
                    }else{
                        boxes[boxid,val] = true;
                    }
                }
            }
        }
        
        return true;
    }
}