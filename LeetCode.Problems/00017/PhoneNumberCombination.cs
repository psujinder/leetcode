namespace LeetCode.Problems;

public class PhoneNumberCombination{

    

    public IList<string> LetterCombinations(string digits) {

        List<string> results = new List<string>();
        
        if(digits.Length == 0){
            return results;
        }
        results.Add("");

        List<string> phoneNumbers = new List<string>();
        phoneNumbers.Add("");
        phoneNumbers.Add("abc");
        phoneNumbers.Add("def");
        phoneNumbers.Add("ghi");
        phoneNumbers.Add("jkl");
        phoneNumbers.Add("mno");
        phoneNumbers.Add("pqrs");
        phoneNumbers.Add("tuv");
        phoneNumbers.Add("wxyz");

        foreach(char digit in digits){
            string numbers = phoneNumbers[digit-'0'-1];

            List<string> tmp = new List<string>();
            foreach(string result in results){
                
                foreach(char number in numbers){
                    tmp.Add(result+number.ToString());
                }
            }
            results = tmp;
        }

        return results;

    }

}