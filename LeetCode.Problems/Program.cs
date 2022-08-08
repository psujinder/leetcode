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

//new IsomorphicString().IsIsomorphic("badc", "baba");

/*Trie trie = new Trie(new TrieNode());
trie.AddEntry("ALL");
trie.AddEntry("ALE");
//trie.AddEntry("I");

trie.Search("HI, ALEX");*/

//new CheckSubsequece().IsSubsequence("abc","ahbgdc");
//new RemoveDuplicates206().RemoveDuplicates(new int[] {0,0,1,1,1,2,2,3,3,4});
//new MaximumNumberOfGroups().MaximumGroups2(new int[]{19,27,8,42,30,27,19,23,46,26,12});
//new FindClosestNodeToGivenTwoNodes().ClosestMeetingNodes(new int[]{2,2,3,-1},0,1);
//new FindClosestNodeToGivenTwoNodes().ClosestMeetingNodes(new int[]{1,2,-1},0,2);
//new FindClosestNodeToGivenTwoNodes().ClosestMeetingNodes(new int[]{4,4,4,5,1,2,2},1,1);
//new LongestCycleInGraph().LongestCyce(new int[] {1,2,0,4,5,6,3,8,9,7});

/*TreeNode p = new TreeNode(1);
p.left = new TreeNode(2);
p.right = new TreeNode(3);

TreeNode q = new TreeNode(1);
q.left = new TreeNode(2);;
q.right = new TreeNode(3);

new SameTree().IsSameTree(p,q);

/*TreeNode p = new TreeNode(1);
p.left = new TreeNode(2);
p.right = null;

TreeNode q = new TreeNode(1);
q.left = null;
q.right = new TreeNode(2);

new SameTree().IsSameTree(p,q);*/


/*TreeNode p = new TreeNode(1);
p.left = null;
p.right = null;

TreeNode q = new TreeNode(1);
q.left = null;
q.right = new TreeNode(2);

new SameTree().IsSameTree(p,q);*/
//new WordLadder().LadderLength("hit", "cog", new List<string>{"hot","dot","dog","lot","log","cog"});

//Console.WriteLine(new LongestIdealSubsequence().Subsequece("acfgbd",2));
Console.WriteLine(new LongestIdealSubsequence().Subsequece("abcd",3));