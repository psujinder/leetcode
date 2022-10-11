namespace LeetCode.Problems;

public class MergeSortedArray {

     public void Merge(int[] nums1, int m, int[] nums2, int n) {

            int[] nums1Copy = new int[m+n];

            for(int i=0; i< m; i++){
                nums1Copy[i] = nums1[i];
            }

            int p1=0, p2=0;

            for(int i = 0; i < m+n; i++){
                
                if(p2 >=n || ( p1 <m && nums1Copy[p1] < nums2[p2])){
                    nums1[i] = nums1Copy[p1++];
                }else{
                    nums1[i] = nums2[p2++];
                }
            }

     }
}