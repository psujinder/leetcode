namespace LeetCode.Problems;

public class CountPrimesPR{

    public int CountPrimes(int n) {
        
        int result = 0;
        bool[] isPrime = new bool[n];

        for(int i=2; i< n; i++){
            isPrime[i] = true;
        }
        
        for(int i = 2; i * i < n; i++){
            if(isPrime[i]){
                for(int j= i*i; j < n; j += i){
                    isPrime[j] = false;
                }
            }
        }

        result = isPrime.Count(p => p == true);
        return result;   
    }

}