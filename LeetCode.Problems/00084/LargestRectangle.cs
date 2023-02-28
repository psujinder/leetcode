namespace LeetCode.Problems;

public class LargestRectangle{

    public int LargestRectangleArea(int[] heights) {
        
        
        int maxArea = 0;
        int len = heights.Length;

        for(int i = 0; i < len; i++){
            int minHeight = Int32.MaxValue;
            for(int j=i; j < len; j++){
                minHeight = Math.Min(minHeight, heights[j]);
                maxArea = Math.Max(maxArea, minHeight* ((j-i)+1));
            }
        }

        return maxArea;
    }

}