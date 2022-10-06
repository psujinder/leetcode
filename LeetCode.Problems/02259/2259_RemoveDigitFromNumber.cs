namespace LeetCode.Problems;

public class RemoveDigitFromNumber{

    public string RemoveDigit(string number, char digit){
        string num  = "";

        int idx = 0;
        
        for(int i=0; i< number.Length; i++){
            if(number[i] == digit){
                idx = i;
                if(i+1 < number.Length  && number[i+1]> number[i]) {
                    break;
                }
            }
        }

        num = number.Substring(0,idx) + number.Substring(idx+1);

        return num;
    }

}