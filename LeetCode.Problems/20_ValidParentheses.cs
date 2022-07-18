namespace LeetCode.Problems;

public class ValidParentheses{

    public bool IsValid(string s) {
        
        Stack<char> stack = new Stack<char>();

        foreach(char c in s){
            if (c == '(' || c == '{' || c == '['){
                stack.Push(c);
            }

           if (c == ')' || c == '}' || c == ']'){
                var isPaired = IsPaired(ref stack, c);
                if (isPaired)
                    stack.Pop();
                else
                    return false;
            }
         

            /*if (c == ')'){
                if (stack.Peek()== '('){
                    stack.Pop();
                }
                else
                    return false;
            }

            if (c == '}'){
                if (stack.Peek()== '{'){
                    stack.Pop();
                }
                else
                    return false;
            }

            if (c == ']'){
                if (stack.Peek()== '['){
                    stack.Pop();
                }
                else
                    return false;
            }*/

        }

        if(stack.Count > 0)
            return false;
        else
            return true;
    }

    private bool IsPaired(ref Stack<char> stack, char c){

        var tmp = stack.Peek();

        switch(c){
            case ')' : return tmp == '(' ? true : false;
            case '}' : return tmp == '{' ? true : false;
            case ']' : return tmp == '[' ? true : false;
        }

        return false;
    }

}