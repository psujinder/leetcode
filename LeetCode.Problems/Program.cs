// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;
using LeetCode.Problems.Utils;

/*Console.WriteLine("Hello, World!");

var capacity =2;

var _solution = new Atoi();

var s = "2147483648";
var result = _solution.MyAtoi(s);
Console.WriteLine(result);*/

/*var ops = new StringOps();
//Console.WriteLine(ops.IsUnique("sekr1s"));
Console.WriteLine(ops.IsPermutation("God", "dog"));*/

/*int[][] matrix = {
    new int[] {0,1,2,0},
    new int[] {3,4,5,2},
    new int[] {1,3,1,5}
};

new ZeroMatrix().SetZeroes(matrix);*/

/*int[][] courses = {
    new int[] {1,4},
    new int[] {2,4},
    new int[] {3,1},
     new int[] {3,2}
};

new CourseSchedule().CanFinish(5,courses);*/

/*TreeNode root = new TreeNode(6);
TreeNode n1 = new TreeNode(2);
TreeNode n2 = new TreeNode(8);
TreeNode n3 = new TreeNode(0);
TreeNode n4 = new TreeNode(4);
TreeNode n5 = new TreeNode(3);
TreeNode n6 = new TreeNode(5);
TreeNode n7 = new TreeNode(7);
TreeNode n8 = new TreeNode(9);

root.right = n2;
root.left = n1;

n2.right = n8;
n2.left = n7;

n1.right = n4;
n1.left = n3;

n4.right = n6;
n4.left = n5;

new LowestCommonAncestor().LCA(root, n1,n2);*/

//new RamsonNote().CanConstruct("aa","ab");

//new PossibleUniquePaths().UniquePaths(3,2);

//new ConstructBinaryTree().BuildTree(new int[]{3,9,20,15,7}, new int[]{9,3,15,20,7});

//new LeetCode.Problems.TaskScheduler().LeastInterval(new char[]{'A','A','A','B','B','B'},2);

/*char[][] board = {
    new char[] {'A','B','C','E'},
    new char[] {'S','F','C','S'},
    new char[] {'A','D','E','E'},
};

new WordSearch().Exist(board, "ABCCED");*/

new FindPivotIndex().PivotIndex(new int[] {1,7,3,6,5,6});