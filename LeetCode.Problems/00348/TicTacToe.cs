namespace LeetCode.Problems;

public class TicTacToe {

    char[,] grid;
    char player1, player2;
    int size;

    public TicTacToe(int n) {
        this.grid = new char[n,n];
        this.player1 = 'X';
        this.player2 = 'O';
        this.size = n;
        
        for(int i=0; i<n ; i++){
            for(int j=0; j<n; j++){
                grid[i,j] = ' ';
            }
        }
    }
    
    public int Move(int row, int col, int player) {
        
        grid[row,col] = (player ==1 ) ? player1: player2;

        //check if the player won
        bool blnWin = false;

        blnWin = (player == 1)? DidPlayerWin(row, col, 'X'):DidPlayerWin(row, col, 'O');

        if(blnWin){
            return (player == 1)? 1:2;
        }else{
            return 0;
        }
    }

    private bool DidPlayerWin(int row, int col, char chtoCheck){

        bool rowWin = true, colWin = true, diaWin= true, antiDiaWin = true;

        //check row
        for(int i=0; i< size; i++){
            if(grid[row, i] != chtoCheck){
                rowWin = false;
                break;
            }
        }

        if(rowWin){
            return true;
        }

        //check col

        for(int i=0; i< size; i++){
            if(grid[i, col] != chtoCheck){
                colWin = false;
                break;
            }
        }

        if(colWin){
            return true;
        }

        //check diagonal
        if(row == col){
            int i=0, j=0;
            while(i < size && j < size){
                if(grid[i,j] != chtoCheck){
                    diaWin =  false;
                    break;
                }
                i++;
                j++;
            }
        }else{
            diaWin = false;
        }

        if(diaWin){
            return true;
        }

        //check anti diagonal
        if(row == size - col-1){
            int i=size-1, j=0;
            while(i < size && j < size){
                if(grid[i,j] != chtoCheck){
                    antiDiaWin =  false;
                    break;
                }
                i--;
                j++;
            }
        }else{
            antiDiaWin = false;
        }

        return antiDiaWin;
    }
}