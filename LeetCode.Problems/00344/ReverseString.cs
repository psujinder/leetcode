namespace LeetCode.Problems;

public class ReverseString{

    public void ReverseString(char[] s) {
        
        int i=0, j= s.Length-1;

        while(i < j){
            var tmp = s[i];
            s[j] = s[i];
            s[i] = tmp;
            i++;
            j--;
        }

    } 

}