namespace LeetCode.Problems;

public class ReshapeMatrix{

    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        
        int[][] result = new int[r][];
    

        if(r*c != mat.Length*mat[0].Length){
            return mat;
        }

        for(int i=0; i< r; i++){
            result[i] = new int[c];
        }

        int row = 0;
        int col = 0;

        for(int i =0; i< mat.Length; i++){
            for(int j =0 ; j< mat[0].Length; j++){
                result[row][col] = mat[i][j];
                col++;

                if(col == c){
                    row++;
                    col = 0;
                }
            }
        }

    

        return result;
    }

}