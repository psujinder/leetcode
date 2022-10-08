namespace LeetCode.Problems;

public class Subsets{

    List<IList<int>> results = new List<IList<int>>();
    public IList<IList<int>> Subset(int[] nums) {

        for(int j=0; j <= nums.Length; j++){
            GenerateSubset(nums, 0, j, new List<int>());
        }

        return results;
    } 

    private void GenerateSubset(int[] nums, int first, int comboLength, List<int> combination){

        if(combination.Count == comboLength){
            results.Add(new List<int>(combination));
            return;
        }

        for(int j=first; j< nums.Length; j++){
            combination.Add(nums[j]);
            GenerateSubset(nums, j+1, comboLength, combination);
            combination.RemoveAt(combination.Count-1);
        }

    }

}