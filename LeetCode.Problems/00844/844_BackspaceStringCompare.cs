namespace LeetCode.Problems;

public class BackspaceStringCompare{

    public bool BackspaceCompare(string s, string t){
        
        if (String.Compare(BackspacedString(s),BackspacedString(t),StringComparison.CurrentCultureIgnoreCase) == 0){
            return true;
        }else{
            return false;
        }

    }

    private string BackspacedString(string s){

        Stack<char> stack = new Stack<char>();
        foreach(char ch in s){
            
            if(ch != '#'){
                stack.Push(ch);
            }else{
                if(stack.Count > 0){
                    stack.Pop();
                }
            }
        }

        string ret = "";

        while (stack.Count > 0){
            ret = stack.Pop()+ret;
        }

        return ret;
    }

}