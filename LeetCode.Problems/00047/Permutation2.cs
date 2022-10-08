namespace LeetCode.Problems;

public class Permutations2{

    List<IList<int>> results = new List<IList<int>>();

    public IList<IList<int>> PermuteUnique(int[] nums) {
       
        Dictionary<int,int> counter = new Dictionary<int, int>();
        
        foreach(int num in nums){
            if(counter.ContainsKey(num)){
                counter[num] ++;
            }else{
                counter.Add(num,1);
            }
        }

        backtrack(counter, nums.Length, new List<int>());

        return results;
    } 

    private void backtrack(Dictionary<int,int> counter, int comblength, List<int> combo){

       if(combo.Count == comblength){
            results.Add(new List<int>(combo));
            return;
       }

       foreach(KeyValuePair<int, int> entry in counter){
            var key = entry.Key;
            var count = entry.Value;

            if(count == 0){
                continue;
            }

            combo.Add(key);
            counter[key] --;

            backtrack(counter, comblength, combo);

            combo.RemoveAt(combo.Count-1);
            counter[key]++;
       }

    }
}