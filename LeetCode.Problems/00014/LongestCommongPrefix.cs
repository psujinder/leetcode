namespace LeetCode.Problems;

public class LongestCommonPrefix_00014{

    public string LongestCommonPrefix(string[] strs){

        if(strs.Count() == 0){
            return "";
        }

        if(strs.Count() == 1){
            return strs[0];
        }

        int idx = Find(strs);
        return strs[0].Substring(0,idx);
    }

    private int Find(string[] strs){

        int idx = -1;

        for(int i=0; i< strs[0].Length; i++){
            char ch = strs[0][i];
            idx = i;
            for(int j=1; j< strs.Length; j++){
                if( i >= strs[j].Length || strs[j][i] != ch){
                    return idx;
                }
            }
        }
        return strs[0].Length;
    }

}