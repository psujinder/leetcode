namespace LeetCode.Problems;

public class SmallerThanSelf2{
     public IList<int> CountSmaller(int[] nums) {
      
        int offset = 10000; // offset negative to non-negative
        int size = 2 * 10000 + 1; // total possible values in nums
        int[] tree = new int[size * 2];
        List<int> result = new List<int>();

        for (int i = nums.Length - 1; i >= 0; i--) {
            int smaller_count = query(0, nums[i] + offset, tree, size);
            result.Add(smaller_count);
            update(nums[i] + offset, 1, tree, size);
        }
        result.Reverse();
        return result;
    }

    // implement segment tree
    private void update(int index, int value, int[] tree, int size) {
        index += size; // shift the index to the leaf
        // update from leaf to root
        tree[index] += value;
        while (index > 1) {
            index /= 2;
            tree[index] = tree[index * 2] + tree[index * 2 + 1];
        }
    }

    private int query(int left, int right, int[] tree, int size) {
        // return sum of [left, right)
        int result = 0;
        left += size; // shift the index to the leaf
        right += size;
        while (left < right) {
            // if left is a right node
            // bring the value and move to parent's right node
            if (left % 2 == 1) {
                result += tree[left];
                left++;
            }
            // else directly move to parent
            left /= 2;
            // if right is a right node
            // bring the value of the left node and move to parent
            if (right % 2 == 1) {
                right--;
                result += tree[right];
            }
            // else directly move to parent
            right /= 2;
        }
        return result;
    }
}