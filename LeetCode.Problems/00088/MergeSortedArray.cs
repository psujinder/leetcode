namespace LeetCode.Problems;

public class MergeSortedArray {

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
         int[] mergedArray = new int[n+m];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < m && j < n){

            if (nums1[i] < nums2[j]){
                mergedArray[k] = nums1[i];
                i++;
                k++;
                continue;
            }

            if (nums1[i] == nums2[j]){
                mergedArray[k] = nums1[i];
                mergedArray[k+1] = nums2[j];
                i++;
                j++;
                k = k +2;
                continue;
            }

            if (nums2[j] < nums1[i]){
                mergedArray[k] = nums2[j];
                j++;
                k++;
                continue;
            }
        }
        
        while (i < m){
            mergedArray[k] = nums1[i];
            i++;
            k++;
        }
    
        while (j < n){
            mergedArray[k] = nums2[j];
            j++;
            k++;
        }
    
        for(i=0; i<=nums1.Length-1; i++){   
            nums1[i] = mergedArray[i];
        }
        
    }
}