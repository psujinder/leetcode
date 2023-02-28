namespace LeetCode.Problems;

public class KthSmallestSortedMatrix{

    public int KthSmallest(int[][] matrix, int k) {

        int len = matrix.Length;
        int l = matrix[0][0];
        int r = matrix[len-1][len-1];
        
        while(l<r){
            int mid = l + (r-l)/2;
            int count = Count(matrix, mid); //code function
            if(count < k){
                l = mid+1;
            }else{
                r = mid;
            }
        }

        return l;
    }

    private int Count(int[][] matrix, int target){
        int n = matrix.Length;
        int i = n-1; 
        int j = 0;
        int count =0;

        while(i>=0 && j<n){
            if(matrix[i][j] <=target){
                count += i+1;
                j++;
            }else{
                i--;
            }
        }

        return count;
    }

}