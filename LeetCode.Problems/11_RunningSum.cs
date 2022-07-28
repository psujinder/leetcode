namespace LeetCode.Problems;

public class RunningSum1d{

    public int[] RunningSum(int[] nums){

        int[] result = new int[nums.Length];    
        int idx = 0;

        foreach(int num in nums){
            if(idx == 0){
                result[idx] = num;
            }else{
                result[idx] = result[idx-1]+num;
            }
            
            idx++;
        }
        
        return result;

    }

}