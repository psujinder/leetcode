namespace LeetCode.Problems;

public class ConstructSmallestNumberFromDIString{

    public string SmallestNumber(string pattern){

        int[] num = new int[pattern.Length+1];
        int lastIncreasingIdx = 0;
        Array.Fill(num,1);

        for(int i = 0; i < pattern.Length; i++){

            if (pattern[i] == 'I'){
                lastIncreasingIdx = i;
                if (i == 0){
                    num[i+1] = num[i]+1;
                }else{
                    num[i+1]= num[i] + num[i-1];
                }
                
            }
            if (pattern[i] == 'D'){
                num[i+1]= num[i] -1;
                if (num[i+1]<=0){
                    for(int j=lastIncreasingIdx; j<= i+1; j++){
                        num[j] = num[j]+1;
                    }
                }
            }

        }

        string result = "";

        for(int i =0; i< num.Length;i++){
            result += num[i].ToString();
        }

        return result;
    }

}