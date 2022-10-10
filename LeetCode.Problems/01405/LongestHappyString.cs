namespace LeetCode.Problems;
using System.Text;

public class LongestHappyString{

    public string LongestDiverseString(int a, int b, int c) {
        
        StringBuilder sb = new StringBuilder();

        int contA=0, contB=0, contC=0;
        int total = a+b+c;

        while (total > 0){

            if((a >= b && a >= c && contA !=2)  || (a>0 && (contB==2 || contC==2))){
                sb.Append('a');
                a--;
                contA++;
                contB=0;
                contC =0;
            }else if((b >= a && b >= c && contB !=2) || (b>0 && (contA==2 || contC==2))){
                sb.Append('b');
                b--;
                contB++;
                contA=0;
                contC =0;
            }else if((c >= a && c >= b && contC !=2)|| (c>0 && (contA==2 || contB==2))){
                sb.Append('c');
                c--;
                contC++;
                contA=0;
                contB =0;
            }

            total--;
        }

        return sb.ToString();
    }

}