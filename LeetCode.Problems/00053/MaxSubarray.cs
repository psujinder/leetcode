namespace LeetCode.Problems;

public class MaxSubarray{

    public int MaxSubArrayTotal(int[] nums) {

        int maxTotal = int.MinValue;
        int currTotal = 0;
        int i=0;

        while (i<= nums.Length -1){

            currTotal += nums[i];

            maxTotal = Math.Max(maxTotal, currTotal);

            if(currTotal < 0){
                currTotal = 0;
            }    

            i++;
        }


        return maxTotal;
    
    }

}