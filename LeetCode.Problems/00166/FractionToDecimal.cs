namespace LeetCode.Problems;

using System.Text;

public class FractionToDecimal1{
    public string FractionToDecimal(int numerator, int denominator) {

        if(numerator == 0){
            return "0";
        }

        StringBuilder sb = new StringBuilder();
        if(numerator <0 && denominator > 0 || numerator > 0 && denominator <0){
            sb.Append("-");
        }

        long dividend = (long)Math.Abs(numerator);
        long divisor = (long)Math.Abs(denominator);
        sb.Append(dividend / divisor);

        long remainder = dividend % divisor;
        if( remainder == 0){
            return  sb.ToString();
        }

        sb.Append(".");

        Dictionary<long,int> map = new Dictionary<long, int>();

        while(remainder != 0){

            if(map.ContainsKey(remainder)){
                sb.Insert(map[remainder],"(");
                sb.Append(")");
                break;
            }

            map[remainder] = sb.Length;
            remainder = remainder * 10;
            sb.Append(remainder / divisor);
            remainder = remainder % divisor;
        }
        
        return sb.ToString();
    }

}