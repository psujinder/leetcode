namespace LeetCode.Problems;
using System;


public class Atoi{

    public int MyAtoi(string s){

        int index = 0;

        //interate through the array to ignore any leading white spaces
        while(s[index] == ' '){
            index ++;
        }

        //use a variable to indicate is the value is negative or positive (positiv by default)
        int sign = 1;

        //next the next character in the sign to determin the if the result is negative or positive number.
        //increment the index only if the character is '-' or '+'
        if(s[index] == '-'){
            sign = -1;
            index++;
        }else if(s[index] == '+'){
            sign = 1;
            index++;
        }
        
        //variable to store the output of the computation
        int result = 0;
        bool isDigit = true;

        int maxValue = int.MaxValue /10;
        int maxValueTail = int.MaxValue % 10;

        //interate through the rest of the string until the character being evaluated is a digit or the end of the string has been reached. 
        while(index < s.Length){
            
            var tmpChar = s[index];
            isDigit = char.IsDigit(tmpChar);
            if(!isDigit)
                return result;

            var tmpDigit = tmpChar - '0';

            if(result < maxValue){
                result = result*10 + tmpDigit;
            }else if (result == maxValue && (tmpDigit > 0 && tmpDigit <= maxValueTail)){
                result = result*10 + tmpDigit;
                return result;
            } else if (result == maxValue && (tmpDigit > maxValueTail)){
                return int.MaxValue;
            }
            else if (result > maxValue){
                return int.MaxValue;
            }

            index++;
        }

        //multiple the result with the sign before returning the result. 
        return result*sign;
    }

}