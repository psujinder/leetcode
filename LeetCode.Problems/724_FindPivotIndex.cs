namespace LeetCode.Problems;

public class FindPivotIndex {

    public int PivotIndex(int[] nums){

       var totalSum = 0;
       var leftsum =0;

       for(int i = 0; i < nums.Length; i++){
        totalSum += nums[i];
       }

        for(int i = 0; i < nums.Length; i++){            
            if(leftsum == totalSum-nums[i]-leftsum){
                return i;
            }else{
                leftsum += nums[i];
            }
        }

        return -1;

    }

}