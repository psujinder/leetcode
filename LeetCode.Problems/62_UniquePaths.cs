namespace LeetCode.Problems;

public class PossibleUniquePaths{

    public int UniquePaths(int m, int n){

        int[][] arr = new int[m][]; 

        for(int i = 0; i < m; i++){
            int[] nArr = new int[n];
            Array.Fill(nArr, 1);
            arr[i] = nArr;
        }

        for(int i = 1; i < m; i++){
            for (int j =1 ; j < n ; j++){
                arr[i][j] = arr[i-1][j]  + arr[i][j-1] ;
            }
        }

        return arr[m-1][n-1];
    }

}