namespace LeetCode.Problems;
using System.Collections.Generic;

public class KthLargestElement{

    public int FindKthLargest(int[] nums, int k) {
        
        int n = nums.Length;

        if (n < k){
            return -1;
        }

        int l = 0;
        int r = n-1;

        while(true){

            int pivotIndex = Partition(nums, l, r);
            int rank = n - pivotIndex;

            if(rank == k){
                return nums[k];
            }else if (rank >k){
                l = pivotIndex+1;
            }else{
                r = pivotIndex -1;
            }
        }

    }

    private int Partition(int[] nums, int l, int r){

        int pivotIndex = l;
        int pivotIndexValue = nums[r];

        for(int i=l; i<=r; i++){
            if(nums[i]< pivotIndexValue){
                Swap(nums, i, pivotIndex);
                pivotIndex++;
            }
        }

        Swap(nums, pivotIndex, r);
        return pivotIndex;
    }

    private void Swap(int[] nums, int i, int j){
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}