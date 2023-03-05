namespace LeetCode.Problems;

public class FindTheCelebrity{
     public int FindCelebrity(int n) {
        int candidate = 0;

        for(int i=1; i<n; i++){
            if(Knows(candidate,i)){
                candidate = i;
            }
        }

        for(int i=0; i< n; i++){
            if(i!= candidate &&(Knows(candidate,i) || !Knows(i, candidate))){
                return -1;
            }
        }

        return candidate;
    }

    private bool Knows(int a, int b) {
    return true;
}
}