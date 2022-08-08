namespace LeetCode.Problems;

public class LongestIdealSubsequence{

    int l =0;

    public int Subsequece(string s, int k){

        DateTime start = DateTime.Now;

        int subsequenceLength = 0;
        
        /*
        longest ideal subsequece is a list of characters in the given string (s), where the order of characters are maitnained
        and the absolute diff between the character are less than or equal to k.
        s = acfgdb, k = 2, output is 4  (acdb)
        */

        int i =0;
        while (i < s.Length){
            if (i <= subsequenceLength){
                 subsequenceLength = Math.Max(subsequenceLength,LongestSubsequenceLength_Recur(s,k,i,i+1));
                 l=0;
            }
            i++;
        }
    
        Console.WriteLine( DateTime.Now - start);
        return subsequenceLength;

    }

    /*private int LongestSubsequenceLength(string s, int k , int i){

        int length = 0;

        int j = i;

        while (j < s.Length-1){
            
            if ( Math.Abs(s[j+1] - s[j]) <= k){
                length = (length == 0)?length+2: length++;
            }
            j++;
        }

        return length;

    }*/

    private int LongestSubsequenceLength_Recur(string s, int k, int i, int j){

        if ( j == s.Length|| i+1 == s.Length){
            return l;
        }

        if (Math.Abs(s[j] - s[i]) <=k){
            l = (l==0)? l+2:l+1;
            
            i++;
            j++;
            if (j-i > 1){
                i = j-1;
            }
            //i = j;
        }
        else{
            j++;
        }
            
        l = LongestSubsequenceLength_Recur(s, k,i,j);

        /*if (l > 0){
            return l+1;
        }*/

        return l;

    }

}