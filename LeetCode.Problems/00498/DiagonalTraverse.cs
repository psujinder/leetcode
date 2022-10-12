namespace LeetCode.Problems;

public class DiagonalTraverse{

    public int[] FindDiagonalOrder(int[][] mat) {
        
        
        int m = mat.Length;
        int n = mat[0].Length;
        List<int> results = new List<int>();
        int row=0, col=0;
        List<int> tmpResult = new List<int>();

        for(int i=0; i < m+n-1; i++){
            tmpResult.Clear();

            row = i < n? 0 : i-n+1;
            col = i < n? i : n-1;

            while(row < m && col > -1){
                tmpResult.Add(mat[row][col]);
                row++;
                col--;
            }
            
            if(i%2 == 0){
                tmpResult.Reverse();
            }
            results.AddRange(tmpResult);
        }

        return results.ToArray();

    }

}