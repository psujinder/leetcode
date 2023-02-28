namespace LeetCode.Problems;

public class LongestConsecutiveSequence{

    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> set = new HashSet<int>(nums);
        int maxSequenceCount = 0;

        foreach(int num in set){

            if(!set.Contains(num-1)){
                int sequenceCount = 1;
                int currNum = num;

                while(set.Contains(currNum+1)){
                    currNum++;
                    sequenceCount++;
                }

                maxSequenceCount = Math.Max(maxSequenceCount,sequenceCount);
            }
        }

        return maxSequenceCount;
    } 

}