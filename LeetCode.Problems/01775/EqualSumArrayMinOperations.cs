namespace LeetCode.Problems;

public class EqualSumArrayWithMinOperations{

    public int MinOperations(int[] nums1, int[] nums2) {
        
        int sum1 = 0;
        int sum2 = 0;

        sum1 = nums1.Sum();
        sum2 = nums2.Sum();

        return (sum1 < sum2) ? MinOps(nums1, sum1, nums2, sum2): MinOps(nums2, sum2, nums1, sum1);
    }

    private int MinOps(int[] minArr, int minSum, int[] maxArr, int maxSum){

        if(maxArr.Length > minArr.Length *6){
            return -1;
        }

        int i=0;
        int j=maxArr.Length-1;
        int steps = 0;
        Array.Sort(minArr);
        Array.Sort(maxArr);

        while (maxSum > minSum){

            if( i <minArr.Length || j<0 && 6-minArr[i] > maxArr[j]-1){
                minSum += 6 -minArr[i];
                i++;
            }else{
                maxSum -= maxArr[j] -1;
                j--;
            }
            steps ++;
        }

        return steps;
    }

}