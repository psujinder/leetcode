namespace LeetCode.Problems;

public class LongestSubstringKRepeating{

    public int LongestSubstring(string s, int k) {
        int n = s.Length;
        int[] count = new int[26];
        int maxUnique = getMaxUniqueChar(s);
        int result = 0;
        
        for (int unique = 1; unique <= maxUnique; unique++) {
            Array.Fill(count, 0);
            int left = 0, right = 0, currUnique = 0, kOrMore = 0;
            
            while (right < n) {
                if (currUnique <= unique) {
                    int index = s[right] - 'a';
                    if (count[index] == 0) {
                        currUnique++;
                    }
                    count[index]++;
                    if (count[index] == k) {
                        kOrMore++;
                    }
                    right++;
                } else {
                    int index = s[left] - 'a';
                    if (count[index] == k) {
                        kOrMore--;
                    }
                    count[index]--;
                    if (count[index] == 0) {
                        currUnique--;
                    }
                    left++;
                }
                
                if (currUnique == unique && currUnique == kOrMore) {
                    result = Math.Max(result, right - left);
                }
            }
        }
        
        return result;
    }
    

    private int getMaxUniqueChar(string s){
        bool[] count = new bool[26];
        int unique =0;

        foreach(char ch in s){
            int idx = ch - 'a';
            if(count[idx] == false){
                count[idx] = true;
                unique++;
            }
        }

        return unique;
    }

}