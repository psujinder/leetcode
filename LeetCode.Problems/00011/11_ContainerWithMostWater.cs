namespace LeetCode.Problems;

public class ContainerWithMostWater{

    public int MaxArea(int[] height) {

        int i = 0, j=height.Length-1;
        int maxArea = Int32.MinValue;

        while(i < j){
            maxArea = Math.Max(maxArea, Math.Min(height[i],height[j]) * (j-i));

            if (height[i] <= height[j]){
                i++;
            }
            else {
                j--;
            }
        }
        return maxArea;

    }

}