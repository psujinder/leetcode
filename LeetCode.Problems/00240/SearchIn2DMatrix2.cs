namespace LeetCode.Problems;

public class Search2DMatrix2{

    public bool SearchMatrix(int[][] matrix, int target) {

        int shortDim = Math.Min(matrix.Length,matrix[0].Length);

        for(int i=0; i < shortDim; i++){
            bool colFound = binarySearch(matrix,target, i, true);
            if(colFound)
                return true;

            bool rowFound = binarySearch(matrix,target, i, false);
            if (rowFound){
                return true;
            }
        }

        return false;
    }

    private bool binarySearch(int[][] matrix, int target, int dim, bool isVertical){

        int mid, row, col;

        int low = dim;
        int high = (isVertical)? matrix.Length-1: matrix[dim].Length-1;

        while(low<=high){
            mid = low + (high-low)/2;
            row = (isVertical)?mid: dim;
            col = (isVertical)?dim:mid;
            if(matrix[row][col] == target){
                return true;
            }else if (matrix[row][col] > target){
                high = mid-1;
            }else {
                low = mid+1;
            }
        }

        return false;
    }
}