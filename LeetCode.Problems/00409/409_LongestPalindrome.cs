namespace LeetCode.Problems;

public class LongestPalindrome2{

    public int LongestPalingdromeLength(string s){

        int length = 0;

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach(char ch in s){
            if(charCount.ContainsKey(ch)){
                charCount[ch]++;
            }else{
                charCount[ch] = 1;
            }
        }
        
        foreach(char key in charCount.Keys){

            int count = charCount[key];

            length += count / 2 *2;
            if( length %2 == 0 && count % 2 ==1){
                length ++;
            }
            
        }

        return length;

    }

}