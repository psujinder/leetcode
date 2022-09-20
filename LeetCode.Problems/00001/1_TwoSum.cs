namespace LeetCode.Problems;

public class TwoSum{

    public int[] Execute(int[] nums, int target){

        
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
               var tmp = target - nums[i];

               if(dict.ContainsKey(tmp)){
                    return new int[]{dict[tmp],i};
               } else{
                    dict.Add(nums[i],i);
               }
        }

        return new int[]{0};
    }

}