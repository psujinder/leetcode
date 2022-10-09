namespace LeetCode.Problems;

using System.Text;

public class ValidPalindrome{

    public bool IsPalindrome(string s) {
        
        int i=0, j=s.Length-1;
        s = s.ToLower();

        while(i<=j && i < s.Length-1 && j >=0){

            while(!char.IsLetterOrDigit(s[i])){
                if( i < s.Length-1)
                    i++;
                else
                    return true;
            }
            
            while(!char.IsLetterOrDigit(s[j])){
                 if( j > 0)
                    j--;
                else
                    return true;
            }

            if(s[i]!= s[j]){
                return false;
            }

            i++;
            j--;
        }

        return true;

    } 

}