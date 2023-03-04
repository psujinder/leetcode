namespace LeetCode.Problems;

public class LongestSubstringWithUtmostK{
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        
        int maxLen=0;
        int l=0, r=0;
        Dictionary<char,int> map = new Dictionary<char, int>();
        
        while(r < s.Length){

            if(!map.ContainsKey(s[r])){
                map.Add(s[r],1);
            }else{
                map[s[r]]++;
            }

            if(map.Count == k+1){
                while(map.Count > k){
                    map[s[l]]--;
                    if(map[s[l]]==0){
                        map.Remove(s[l]);
                    }
                    l++;
                }
            }
            maxLen = Math.Max(maxLen, r-l+1);
            r++;
        }

        return maxLen;
    }
}