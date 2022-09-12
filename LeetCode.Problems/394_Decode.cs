namespace LeetCode.Problems;

public class DecodeString{

    public string DecodedString(string s){

        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            
            if(s[i] != ']'){
                stack.Push(s[i]);
            }else{
                List<char> repeatChar = new List<char>();
                while(stack.Peek() != '['){
                    //tmpString += stack.Pop();
                    repeatChar.Add(stack.Pop());
                }
                stack.Pop();

                int val = 0;
                int base1 = 1;
                while (stack.Count > 0 &&  Char.IsDigit(stack.Peek())){
                    val = val + (stack.Pop() - '0') * base1;
                    base1 *= 10;
                }

                while (val > 0){
                    for(int j = repeatChar.Count -1; j >= 0; j--){
                        stack.Push(repeatChar[j]);
                    }
                    val -=1;
                }
            }
        }

        char[] decodedString = new char[stack.Count];
        int k = stack.Count-1;
        while(stack.Count>0){
            decodedString[k] = stack.Pop();
            k--;
        }

        return new String(decodedString);

    }

}