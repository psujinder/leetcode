namespace LeetCode.Problems;

public class SignOfArrayProduct{

    public int ArraySign(int[] nums){

        int count;

        count = nums.Count(p => p == 0);

        if(count > 0)
            return 0;
        
        count = nums.Count(p => p <0);
        
        if(count % 2 == 0){
            return 1;
        }else{
            return -1;
        }

    }

}