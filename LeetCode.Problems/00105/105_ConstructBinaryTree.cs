namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class ConstructBinaryTree{

    int preorderIndex = 0;
    Dictionary<int, int> inorderMap = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {

        for(int i = 0; i < inorder.Length; i++){
            inorderMap.Add(inorder[i],i);
        }

        return arrayToTree(preorder, 0, preorder.Length -1);
    } 

    public TreeNode arrayToTree(int[] preorder, int left, int right){
       if (left > right) return null;

        // select the preorder_index element as the root and increment it
        int rootValue = preorder[preorderIndex++];
        TreeNode root = new TreeNode(rootValue);

        // build left and right subtree
        // excluding inorderIndexMap[rootValue] element because it's the root
        root.left = arrayToTree(preorder, left, inorderMap[rootValue] - 1);
        root.right = arrayToTree(preorder, inorderMap[rootValue] + 1, right);
        return root;
    }

}