namespace LeetCode.Problems;
using LeetCode.Problems.Utils;

public class RecoverBST{

    List<int> nums = new List<int>();
    int x, y;

    public void RecoverTree(TreeNode root) {
        inOrder(root);
        findNodes();
        swap(2,root);
    }

    private void inOrder(TreeNode root){
       if(root == null){
            return;
       }
       inOrder(root.left);
       nums.Add(root.val);
       inOrder(root.right);
    }

    private void findNodes(){
        int n = nums.Count();
        bool firstTime = false;
        for(int i = 0; i < n - 1; ++i) {
            if (nums[i + 1] < nums[i]) {
                y = nums[i + 1];
                if (!firstTime) {
                    x = nums[i];
                    firstTime = true;
                } else {
                    break;
                }
            }
        }
    }

    private void swap(int count, TreeNode root){
        if (root != null) {
            if (root.val == x || root.val == y) {
                root.val = root.val == x ? y : x;
                count--;
                if (count == 0)
                    return;
            }
            swap(count, root.left);
            swap(count, root.right);
        }
    }

}