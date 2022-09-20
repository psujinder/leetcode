namespace LeetCode.Problems;

public class CheckValidPartition {

    public bool ValidPartition(int[] nums) {

        int[] dp = new int[nums.Length];
        Array.Fill(dp,-1);
        if (nums.Length <2){
            return false;
        }

        return ValidateArray(nums, 0, dp);

        //return false;   
    }

    private bool ValidateArray(int[] nums, int i, int[] dp){

        if (i == nums.Length){
            return true;
        }

        if(dp[i] != -1)
            return dp[i] ==1?true:false;

        if (i+1 < nums.Length && nums[i] == nums[i+1]){
           
           if(ValidateArray(nums, i+2, dp)){
                dp[i] = 1;
                return true;
           }
            
        }

        if (i+2< nums.Length && nums[i] == nums[i+1] && nums[i+1] == nums[i+2]){
            
            if(ValidateArray(nums, i+3, dp)){
                dp[i] = 1;
                return true;
            }
        }    
        
        if (i+2 < nums.Length && nums[i+1] == nums[i]+1 && nums[i+2] == nums[i+1]+1){
           
            if(ValidateArray(nums, i+3, dp)){
                dp[i] = 1;
                return true;
            }
        }

        dp[i] = 0;

        return false;

    }


}