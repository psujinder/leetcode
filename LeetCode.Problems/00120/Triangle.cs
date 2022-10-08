namespace LeetCode.Problems;

public class Triangle{

   public int MinimumTotal(IList<IList<int>> triangle) {

      if(triangle.Count == 0){
         return 0;
      }

      if(triangle.Count == 1){
         return triangle[0][0];
      }
 
      for(int i = 1; i< triangle.Count; i++){
         for(int j = 0; j < triangle[i].Count; j++){
            if(j-1 < 0){
               triangle[i][j] = triangle[i-1][j]+triangle[i][j];
            } else if (j >= triangle[i-1].Count){
               triangle[i][j] = triangle[i-1][j-1]+triangle[i][j];
            }else{
               triangle[i][j] = Math.Min(triangle[i-1][j-1]+triangle[i][j], triangle[i-1][j]+triangle[i][j]);
            }
         }
      }

      return triangle.Last().Min();

   }

}