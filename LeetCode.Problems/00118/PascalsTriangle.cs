namespace LeetCode.Problems;

public class PascalsTriangle{

    public IList<IList<int>> Generate(int numRows){

        List<IList<int>> triangle = new List<IList<int>>();

        if(numRows == 0){
            return triangle;
        }

        triangle.Add(new List<int>(1){1});
        if(numRows==1){
            return triangle;
        }

        for(int i=1; i <numRows;i++){

            var row = new List<int>(i+1);

            row.Add(1);

            for(int j=1; j<i ; j++){
                row.Add(triangle[i-1][j-1]+ triangle[i-1][j]);
            }
            row.Add(1);

            triangle.Add(row);
        }

        return triangle;

    }

}