namespace LeetCode.Problems;

public class CombinationSum{

    List<IList<int>> results = new List<IList<int>>();

    public IList<IList<int>> CombSum(int[] candidates, int target) {

        if(target < candidates.Min()){
            return results;
        }

        Array.Sort(candidates);
        //for(int i = 0; i< candidates.Length; i++){
            backtrack(candidates, target,0,  new List<int>());
        //}
        
        return results;
    }

    private void backtrack(int[] candidates, int target, int first, List<int> combo){

        if(combo.Sum() > target){
            return;
        }

        if(combo.Sum() == target){
            results.Add(new List<int>(combo));
            return;
        }

        for(int i=first; i< candidates.Length; i++){
            combo.Add(candidates[i]);
            backtrack(candidates,target, i, combo);
            combo.RemoveAt(combo.Count-1);
        }
        

    }

}