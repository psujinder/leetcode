namespace LeetCode.Problems;

public class CountingBits{

    public int[] CountBits(int n){

        int[] ans = new int[n+1];
        ans[0] = 0;

        for (int i= 1; i <= n; i++){

            if( i % 2 == 0){
                ans[i] = ans[i/2];
            }else{
                ans[i] = ans[i/2] +1;
            }
        }

    }

}