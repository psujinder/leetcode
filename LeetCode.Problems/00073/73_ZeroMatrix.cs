namespace LeetCode.Problems;

public class ZeroMatrix{

    public void SetZeroes(int[][] matrix){

        //determine the indices where the cell is a zero
        var rowCount = matrix.Length;
        var columnCount = matrix[0].Length;
        bool[] rows = new bool[rowCount];
        bool[] columns = new bool[columnCount];

        for (int i = 0; i< rowCount; i++ ){
            for (int j = 0; j < columnCount; j++){
                if(matrix[i][j] == 0){
                    rows[i] = true;
                    columns[j] = true;
                }
            }
        }

        //for the row where the cell is zero, set all elements in the row to 0
        for(int i = 0; i < rows.Length; i++){
            if(rows[i] == true){
                for(int j = 0; j< columnCount; j++){
                    matrix[i][j] = 0;
                }
            }
        }

        //for the column where the cell is zero set all elements in the column to 0
        for(int i = 0; i < columns.Length; i++){
            if(columns[i] == true){
                for(int j = 0; j< rowCount; j++){
                    matrix[j][i] = 0;
                }
            }
        }
    }
}