namespace LeetCode.Problems;

public class LongestRepeatingCharacterReplacement{

    public int characterReplacement(String s, int k) {
        
        int result = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();

        int l =0;
        int max = 0;

        for (int r = 0; r < s.Length; r++){
            if(map.ContainsKey(s[r])){
                map[s[r]]++;
            }else{
                map.Add(s[r],1);
            }
            max = Math.Max(max, map[s[r]]);

            //int freq = r - l +1 - map.MaxBy(p=> p.Value).Value;
            int freq = r - l +1 - max;

            if(freq <= k){
                result = Math.Max(result,r - l +1);
            }else{
                map[s[l]]--;
                l++;
            }
             
        }

        return result;

    }

}