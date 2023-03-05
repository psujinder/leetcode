namespace LeetCode.Problems;

using System.Text;

public class LargestNumber_PR{

    public string LargestNumber(int[] nums) {
        
        string[] strs = new string[nums.Length];

        for(int i=0; i< strs.Length;i++){
            strs[i] = nums[i].ToString();
        }

        Array.Sort(strs, (a,b)=>{
            string ab = a+b;
            string ba = b+a;
            return ba.CompareTo(ab);
        });

        if(strs[0] == "0"){
            return "0";
        }
        
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs){
            sb.Append(str);
        }

        return sb.ToString();
    }

}