namespace LeetCode.Problems;
using System.Text;

public class DefangingIPAddress{

    public string DefangIPaddr(string address) {

        StringBuilder builder = new StringBuilder();

        foreach(char ch in address){
            if(ch == '.'){
                builder.Append("[.]");
            }else{
                builder.Append(ch);
            }
        }

        return builder.ToString();
    }

}