namespace LeetCode.Problems;

public class Sqrt{

    public int MySqrt(int x) {

        if(x < 2){return x;}

        int l = 2;
        int r = x/2;
        int mid = 0;

        while (l <= r){
            mid = l + (r-l)/2;

            long val = (long)mid * (long)mid;

            if(val == x){
                return mid;
            }else if (val > x){
                r = mid -1;
            }else {
                l = mid + 1;
            }
        }

        return r;
    }

}