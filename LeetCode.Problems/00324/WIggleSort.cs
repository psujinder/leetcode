namespace LeetCode.Problems;

public class WiggleSort_PR{

    public void WiggleSort(int[] nums) {
        
        int len = nums.Length;

        int[] sorted = new int[len];

        Array.Copy(nums,sorted,len);
        Array.Sort(sorted);

        int mid = (len % 2 == 0)? len/2-1:len/2;
        int[] first = new int[mid+1];
        int[] second = new int[len-mid-1];

        Array.Copy(sorted,0,first,0,mid+1);
        Array.Copy(sorted,mid+1,second,0,len - mid -1);

        Array.Reverse(first);
        Array.Reverse(second);

        for(int i=0, j=0, k=0; i< len;i++){
            nums[i] = (i%2 ==0)? first[j++]:second[k++];
        }

    } 

}