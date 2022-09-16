namespace LeetCode.Problems;

public class TicTacToe{

    public string TictactoeGame(int[][] moves) {
        
        char[][] grid = new char[3][];
        for(int i=0; i < grid.Length; i++){
            grid[i] = new char[3];
        }

        string winner = "";
        string player = "A";
        bool isA = true;
        //Fill grid
        for(int i=0; i < moves.Length; i++){
            int row = moves[i][0];
            int column = moves[i][1];

            if(isA)
                grid[row][column] = 'x';
            else
                grid[row][column] = 'o';
            
            if (CheckRow(grid,row,column))
                return player;

            if (CheckColumn(grid,row,column))
                return player;

            if(CheckDiagonal1(grid,row,column))
                return player;

            if(CheckDiagonal2(grid,row,column))
                return player;

            isA = !isA;
            if (isA){
                player = "A";
            }else{
                player = "B";
            }
            
        }

        //check if there are any pending moves or it is a draw
        if(moves.Length == 3 *3){
            return "Draw";
        }else{
            return "Pending";
        }
    }


    private bool CheckRow(char[][]grid, int row, int column){

        char ch = grid[row][column];

        for(int i = 0; i < grid[0].Length; i++){
            if (ch != grid[row][i]){
                return false;
            }
        }

        return true;;

    }

    private bool CheckColumn(char[][]grid, int row, int column){

        char ch = grid[row][column];

        for(int i = 0; i < grid[0].Length; i++){
            if (ch != grid[i][column]){
                return false;
            }
        }

        return true;;

    }

    private bool CheckDiagonal1(char[][]grid, int row, int column){

        char ch = grid[row][column];

        for(int i = 0; i < grid[0].Length; i++){
            if (ch != grid[i][i]){
                return false;
            }
        }

        return true;;

    }

    private bool CheckDiagonal2(char[][]grid, int row, int column){

        char ch = grid[row][column];

        int j = 0;
        for(int i = grid[0].Length-1; i >= 0; i--){
            if (ch != grid[i][j]){
                return false;
            }
            j++;
        }

        return true;;

    }

   
}