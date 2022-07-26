namespace LeetCode.Problems;

public class WordSearch {

    int rows;
    int columns;

    char[][] board;

    public bool Exist(char[][] board, string word){

        rows = board.Length;
        columns = board[0].Length;
        this.board = board;

        for(int i=0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                if(backtrack(i,j,word, 0)){
                    return true;
                }
            }
        }

        return false;
    }

    public bool backtrack(int row, int column, string word, int index){

        if(index >= word.Length)
            return true;

        if(row <0  || row == rows || column == columns || column < 0 || 
        word[index] != board[row][column])
            return false;
        
        var ret = false;
        board[row][column] = '#';

        int[] rowOffset = {0,0,-1,1};
        int[] columnOffset = {1,-1,0,0};

        for(int i = 0; i < 4; i++){
            ret = backtrack(row+rowOffset[i], column+columnOffset[i], word,index +1);
            if(ret)
                break;
        }

        board[row][column] = word[index];
        return ret;

    }

}