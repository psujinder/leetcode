namespace LeetCode.Problems;
using LeetCode.Problems.Utils;

public class BinaryTreeRighSide{

    public IList<int> RightSideView (TreeNode root){

            List<int> nums = new List<int>();

            if (root == null){
                return nums;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while(stack.Count > 0){
                TreeNode node = stack.Pop();

                nums.Add(node.val);
                if(node.right !=null){
                    stack.Push(node.right);
                }
            }
            
            return nums;

    }

}