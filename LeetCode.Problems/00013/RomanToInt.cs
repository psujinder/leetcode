namespace LeetCode.Problems;

public class RomanToInteger{

    public int RomanToInt(string s){

        int result = 0;

        Dictionary<char,int> map =new Dictionary<char, int>();

        map.Add('I',1);
        map.Add('V',5);
        map.Add('X',10);
        map.Add('L',50);
        map.Add('C',100);
        map.Add('D',500);
        map.Add('M',1000);

        int prev = -1;

        for(int i=s.Length-1; i>=0;i--){

            if(map[s[i]] >= prev){
                result = result+map[s[i]];
            }else{
                result = result - map[s[i]];
            }
            prev = map[s[i]];
        }

        return result;

    }

}