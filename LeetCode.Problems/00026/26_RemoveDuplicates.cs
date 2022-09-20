namespace LeetCode.Problems;

public class RemoveDuplicates206{

    public int RemoveDuplicates(int[] nums){

        int i =0;

        for(int j = 1; j< nums.Length;j++){
            if(nums[j] != nums[i]){
                i++;
                nums[i] = nums[j];
            }
        }

        return i+1;

    }
    

    public int RemoveDuplicates2(int[] nums){

        int k =0;
        List<int> visitedNums = new List<int>();
        int leftIdx = nums.Length - 1;

        while (k <= leftIdx){

            if( visitedNums.Contains(nums[k])){
                //move the element to the left of the array
                var tmp = nums[k];
                for (int i = k; i<= leftIdx-1; i++){
                    nums[i] = nums[i+1];
                }
                nums[nums.Length-1] = tmp;
                leftIdx --;
            }else{
                //add the element to visitedNums
                visitedNums.Add(nums[k]);
                k++;
            }

        }

        return k;

    }

    

}