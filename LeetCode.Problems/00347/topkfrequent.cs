namespace LeetCode.Problems;

public class TopKFrequentUsed{

    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> map = new Dictionary<int, int>();

        foreach(int num in nums){
            if(map.ContainsKey(num)){
                map[num]++;
            }else{
                map.Add(num,1);
            }
        }

        SortedDictionary<int,List<int>> countFreq = new SortedDictionary<int, List<int>>(Comparer<int>.Create((a, b) => map[a].CompareTo(map[b])));

        foreach(KeyValuePair<int,int> pair in map){
            if(countFreq.ContainsKey(pair.Value)){
                countFreq[pair.Value].Add(pair.Key);
            }else{
                countFreq.Add(pair.Value, new List<int>(){pair.Key});
            }
        }

        List<int> result = new List<int>();

        foreach(int key in countFreq.Keys){

            foreach(int val in countFreq[key]){
                result.Add(val);
                k--;
                if(k==0){
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    } 

}