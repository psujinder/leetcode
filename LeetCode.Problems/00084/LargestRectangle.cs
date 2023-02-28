namespace LeetCode.Problems;

public class LargestRectangle{

    public int LargestRectangleArea(int[] heights) {
        
        int l = 0;
        int r = 0;
        int maxArea = heights[0] *1;
        int height = heights[0];

        while (r < heights.Length){

            int currRectArea = heights[r] * 1;
            height = Math.Min(height, heights[r]);
            int currArea = height * ((r-l)+1);
            
            maxArea = Math.Max(maxArea,Math.Max(currArea,currRectArea));
            if(currRectArea >= currArea){
                l = r;
                height = heights[r];
            }

            r++;
           
        }

        return maxArea;
    }

}