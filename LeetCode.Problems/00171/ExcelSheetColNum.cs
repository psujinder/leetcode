namespace LeetCode.Problems;

public class ExcelSheetColumnNumber {
    public int TitleToNumber(string columnTitle) {

        int result =0;

        int j = columnTitle.Length-1;

        for(int i=0; i<columnTitle.Length;i++){

            int value = columnTitle[i] - 'A' +1;
            result += value * (int)Math.Pow(26,j);
            j--;
        }

        return result;    
    }

}