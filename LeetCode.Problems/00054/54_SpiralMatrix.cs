namespace LeetCode.Problems;

public class SpiralMatrix {

     public IList<int> SpiralOrder(int[][] matrix) {
        
        int left = 0, right = 0, top = 0, down =0;

        int rows = matrix.Length;
        int columns = matrix[0].Length;

        down = rows -1;
        right = columns -1;

        List<int> result = new List<int>();

        while(result.Count < rows * columns){

            //move from left to right
            for (int i = left; i <= right; i++){
                result.Add (matrix[top][i]);
            }

            //move from top to bottom
            for(int i = top+1; i<=down; i++){
                result.Add(matrix[i][right]);
            }

            //move from right to left
            if (top != down){
                 for(int i = right-1; i>=left; i--){
                    result.Add(matrix[down][i]);
                }
            }
           
            //move from down to top
            if (left != right){
                for(int i = down-1; i > top; i--){
                    result.Add(matrix[i][left]);
                }
            }
            

            left ++;
            right --;
            top ++ ;
            down --;
        }

        return result;

    }

}