namespace LeetCode.Problems;
using System;


public class Atoi{

    public int MyAtoi(string s){

        int index = 0;

        s = s.TrimStart();

        if (s.Length == 0 ){
            return 0;
        }

        int sign =1;

        if(s[index] == '-'){
            sign = -1;
            index++;
        }else if (s[index] == '+'){
            index++;
        }

        //max integer 2,147,483,647
        //min integer -2,147,483,648
        int value = 0;

        int maxValue = Int32.MaxValue / 10;
        int minValue = Int32.MinValue / 10;

        while( index < s.Length && char.IsNumber(s[index])){

            int tmpDigit = s[index] -'0';
        
            if(sign == 1){
                if(value < maxValue){
                    value = value *10 + tmpDigit;
                }else if (value == maxValue && tmpDigit <= 7 ){
                    value = value *10 + tmpDigit;
                }else if (value == maxValue && tmpDigit > 7 || value > maxValue) {
                    value = Int32.MaxValue;
                }
            }else{
                if(value > minValue){
                    value = (value *10 - tmpDigit);
                }else if (value == minValue && tmpDigit <= 8 ){
                    value = value *10 - tmpDigit;
                }else if (value == minValue && tmpDigit > 8 || value < minValue) {
                    value = Int32.MinValue;
                }
            }
            
            index++;
        }
        
        return value;
    }


    public int MyAtoi2(string s){

        int index = 0;
        int n = s.Length;
        int sign = 1;

        while(index < n && s[index]== ' '){
            index++;
        }

        if(index < n && s[index] == '-'){
            sign = -1;
            index++;
        }else if(index < n && s[index] == '+'){
            sign = 1;
            index++;
        }

        int value = 0;

        while(index < n && char.IsNumber(s[index])){
            int digit = s[index] - '0';

            if(value > Int32.MaxValue / 10 || (value == Int32.MaxValue && digit > Int32.MaxValue % 10)){
                return (sign == 1)? Int32.MaxValue : Int32.MinValue;
            }

            value = value*10 +digit;
            index++;
        }

        return value * sign;

        
    }

}