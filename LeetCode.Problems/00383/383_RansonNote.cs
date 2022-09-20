namespace LeetCode.Problems;

public class RamsonNote{

    public bool CanConstruct(string ransomNote, string magazine) {

        bool isPossible = true;

        foreach(var ch in ransomNote){
            if(magazine.Contains(ch)){
                int firstIdx = magazine.IndexOf(ch);
                if(firstIdx != -1){
                    magazine = magazine.Remove(firstIdx,1);
                }
                else{
                    isPossible = false;
                    break;
                }
            }else{
                isPossible = false;
            }
        }

        return isPossible;   
    }

}