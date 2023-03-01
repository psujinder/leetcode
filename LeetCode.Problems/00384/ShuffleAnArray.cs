namespace LeetCode.Problems;

public class ShullfleArray{

    private int[] nums;
    private int[] shuffled;

    public ShullfleArray(int[] nums){
        this.nums = nums;
        this.shuffled = nums.Clone() as int[];
    }

    public int[] Reset() {
        return nums;
    }
    
    public int[] Shuffle() {
        
        Random rnd = new Random();

        for(int j= 0; j < shuffled.Length; j++){
            int i= rnd.Next(j, shuffled.Length);
            int tmp = shuffled[j];
            shuffled[j] = shuffled[i];
            shuffled[i] = tmp; 
        }

        return shuffled;
        
    }
}