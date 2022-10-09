namespace LeetCode.Problems;

public class ReverseString{

    public void Reverse(char[] s) {
        
        int i=0, j= s.Length-1;

        while(i < j){
            var tmp = s[i];
            s[i] = s[j];
            s[j] = tmp;
            i++;
            j--;
        }

    } 

}