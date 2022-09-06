namespace LeetCode.Problems;

public class LongestPalindrome {

    public string LongestPalindromeString (string s){

        var palindrome = "";       
        int center = 0;
        int radius = 0;
        int maxCenter = 0;
        int maxRadius = 0;
        string modifiedString = "#";

        if (s == "" || s.Length <1 ){
            return "";
        }

        //modify the string by inserting a character at the beginning, end and in between each character. In this case I am inserting the character #
        foreach(char ch in s){
            modifiedString += ch+"#";
        }        

        while (center < modifiedString.Length){
               radius = 0;

               while( center-(radius+1) >= 0 && center + (radius+1) < modifiedString.Length && modifiedString[center-(radius+1)] == modifiedString[center+(radius+1)]){
                        radius ++;
               } 

              if (radius > maxRadius){
                maxRadius = radius;
                maxCenter = center;                
              }

              center ++;
        }

        for (int i = maxCenter - maxRadius; i<= maxCenter+maxRadius; i++){
             if(modifiedString[i] != '#'){
                palindrome += modifiedString[i];     
             }             
        }
        
        return palindrome;
    }

}