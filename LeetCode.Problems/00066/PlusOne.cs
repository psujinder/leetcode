namespace LeetCode.Problems;

public class AddOne{

    public int[] PlusOne(int[] digits) {

        List<int> nums = new List<int>(digits);

        for(int i=digits.Count()-1; i > 0; i--){

            if(nums[i] < 9){
                nums[i]++;
                break;
            }

            nums[i] = 0;
            if(i==0){
                nums.Insert(0,1);
            }
        }   

        return nums.ToArray();
    }

}