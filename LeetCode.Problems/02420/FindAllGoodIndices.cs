namespace LeetCode.Problems;

public class FindAllGoodIndices{
    public IList<int> GoodIndices(int[] nums, int k) {
        
        List<int> result = new List<int>();
        int before = 0;
        int after = 0;
        bool blnBefore ;
        bool blnAfter;
        for(int i =k; i< nums.Length-k; i++){

            blnAfter = true;
            blnBefore = true;

            //check the elements before
            int j = i-k;
            j = Math.Max(before, i-k);

            while(j < i-1){
                if(nums[j] < nums[j+1]){
                    blnBefore = false;
                    break;
                }
                j++;
            }

            if (blnBefore){
                j = Math.Max(i+1, after);

                while(j < i+k){
                    if(nums[j] > nums[j+1]){
                        blnAfter = false;
                        break;
                    }
                    j++;
                }
            }

            if(blnAfter && blnBefore){
                before = i-1;
                after = i+k-1;
                result.Add(i);
            }
        }

        return result;

    }

}