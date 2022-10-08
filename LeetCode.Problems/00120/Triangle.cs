namespace LeetCode.Problems;

public class Triangle{

   public int MinimumTotal(IList<IList<int>> triangle) {

        int result;
        int minIdx = 0;
        result = triangle[0][0];

        if(triangle.Count == 1){
            return result;
        }

        for(int i=1; i < triangle.Count; i++){
             
             if(triangle[i][minIdx] < triangle[i][minIdx+1]){
                result = result + triangle[i][minIdx];
             }else{
                result = result + triangle[i][minIdx+1];
                minIdx++;
             }
        }

        return result;

   }

}