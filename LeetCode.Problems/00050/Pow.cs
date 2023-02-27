namespace LeetCode.Problems;

public class Pow{

    public double MyPow(double x, int n) {
        
        if(n == 0){return 1;}
        if(n == 1){return x;}

        long p = (long) n;

        if( n < 0){
            p = -p;
            x = 1/x;
        }

        double result = 1;

        while( p > 0){  
            if( p %2 == 1){
                result = result *x;
            }

            x = x*x;
            p = p/2;
        }

        return result;
    }

}