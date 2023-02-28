namespace LeetCode.Problems;

public class FizzBuzz{

    public IList<string> fizzBuzz(int n) {
        
        List<string> result = new List<string>();

        for(int i=1; i<=n; i++){
             if(i%3 == 0 && i%5 == 0){
                result.Add("FizzBuzz");
            }else if (i%3 == 0){
                result.Add("Fizz");
            }else if (i%5 == 0){
                result.Add("Buzz");
            }else{
                result.Add($"{i}");
            }
        }
       
        return result;
    }

}