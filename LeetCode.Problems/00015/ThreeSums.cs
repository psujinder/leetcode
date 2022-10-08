namespace LeetCode.Problems;

public class ThreeSums{

    public IList<IList<int>> ThreeSum(int[] nums) {
        
        List<IList<int>> results = new List<IList<int>>();

        for(int i=0; i< nums.Length; i++){
            int[] tmpResults = TwoSum(nums, i);

            if(tmpResults.Length != 0){
                List<int> tmp = tmpResults.ToList();
                tmp.Add(nums[i]);
                results.Add(tmp);
            }
            
        }

        return results;
    }

    //key is the number
    //value is the index
    private int[] TwoSum(int[] nums, int i){

        Dictionary<int, int> map = new Dictionary<int, int>();
        int complement = 0 - nums[i];

        for (int j=0; j<nums.Length; j++){
            
            

        }

        return new int[]{};
    }

}