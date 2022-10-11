namespace LeetCode.Problems;

public class Search2DMatrix{

    public bool SearchMatrix(int[][] matrix, int target) {
        
        int l=0, r= matrix.Length * matrix[0].Length-1;
        int row, col;
        int mid;
        int n = matrix[0].Length;

        while(l<=r){
            mid = (l+r) /2;

            row = mid / n;
            col = mid % n;
            
            if(matrix[row][col] == target){
                return true;
            }else if (matrix[row][col] < target){
                l = mid+1;
            }else{
                r = mid-1;
            }
        }

        return false;
    } 

}