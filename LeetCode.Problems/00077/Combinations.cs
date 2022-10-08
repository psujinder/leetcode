namespace LeetCode.Problems;

public class Combinations{

    public IList<IList<int>> Combine(int n, int k) {

      return backtrack(1, new List<int>(),new List<IList<int>>(), n,k);
    
    } 

    private List<IList<int>>  backtrack(int first, List<int> combination, List<IList<int>> results, int n, int k){

        if(combination.Count == k){
            results.Add(new List<int>(combination));
            return results;
        }

        for( int i = first; i < n+1; i++){
            combination.Add(i);
            backtrack(i+1, combination, results, n,k);
            combination.RemoveAt(combination.Count-1);
        }

        return results;
    }
   
}