namespace LeetCode.Problems;

public class CountingBits{

    public int[] CountBits(int n){

        int[] ans = new int[n+1];

        for (int i= 0; i <= n; i++){

            ans[i] = (i%2 == 0) ? ans[i] = ans[i/2] :  ans[i] = ans[i/2] +1;
            
        }

        return ans;
    }

}