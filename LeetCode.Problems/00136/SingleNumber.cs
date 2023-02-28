namespace LeetCode.Problems;

public class SingleNumberPR {

    public int SingleNumber(int[] nums) {
        
        Dictionary<int, int> map = new Dictionary<int, int>();
        int result;

        foreach(int num in nums){
            if(map.ContainsKey(num)){
                map[num]++;
            }else{
                map.Add(num,1);
            }
        }

        foreach(int key in map.Keys){
            if(map[key] == 1){
                result = key;
                break;
            }
        }
    
        return result;
    } 

}