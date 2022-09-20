namespace LeetCode.Problems;

public class LongestSubstringWithoutRepeatingCharacter{

    public int LengthOfLongestSubstring(string s){

        int longestLength = 0;
        Dictionary<char,int> map = new Dictionary<char, int>();
        var i = 0;
        
        for(int j=0; j< s.Length;j++){

            if(map.ContainsKey(s[j])){
                i = Math.Max(map[s[j]],i);
                map[s[j]] = j+1;
            }else{
                map.Add(s[j],j+1);
            }
            longestLength = Math.Max(longestLength,j-i+1);
        }
        return longestLength;

    }

}