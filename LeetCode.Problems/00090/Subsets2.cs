namespace LeetCode.Problems;

public class Subsets2{

    List<IList<int>> results = new List<IList<int>>();

    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        for(int i=0; i <= nums.Length; i++){
            GenerateSubsets(nums, i, 0, new List<int>());
        }

        return results;
    } 

    private void GenerateSubsets(int[] nums, int comboLength, int first, List<int> combination){

        if(combination.Count == comboLength){
            results.Add(new List<int>(combination));
            return;
        }

        for(int i = first; i< nums.Length; i++){
            if(i != first && nums[i] == nums[i-1]){
                continue;
            }
            combination.Add(nums[i]);
            GenerateSubsets(nums, comboLength, i+1, combination);
            combination.RemoveAt(combination.Count -1);
        }
    }
    
}