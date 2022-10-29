namespace LeetCode.Problems;

public class TrappingRainWater{

    public int Trap(int[] height) {
        
        int ans = 0;
        int size = height.Length;
        int[] left_max = new int[size];
        int[] right_max = new int[size];


        left_max[0] = height[0];
        right_max[size-1] = height[size-1];

        for(int i=1; i< size; i++){
            left_max[i] = Math.Max(height[i], left_max[i-1]);
        }

        for(int i = size-2; i >= 0; i--){
            right_max[i] = Math.Max(height[i], right_max[i+1]);
        }

        for(int i=0; i< size-1; i++){
            ans += Math.Min(left_max[i], right_max[i]) -height[i];
        }

        return ans;

    }

}