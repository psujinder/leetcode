namespace LeetCode.Problems;

public class UniqueSumToZero{

    public int[] SumZero(int n){

        int[] res = new int[n];
        int mid = n/2;
        if (n%2 ==0){
            for (int i = 0; i <=mid;i++){
                res[i] = -n;
                res[n-1] = n;
                n--;
            }
        }else{
            for (int i = 0; i <=mid;i++){
                res[i] = -n;
                res[n-1] = n;
                n--;
            }
            res[mid] = 0;
        }

        return res;
    }

}