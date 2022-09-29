// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;
using LeetCode.Problems.Utils;
using System.Globalization;

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

//Console.WriteLine(new LongestIdealSubsequence().LongestIdealString("acfgbd",2));
//Console.WriteLine(new LongestIdealSubsequence().LongestIdealString("abcd",3));
//Console.WriteLine(new LongestIdealSubsequence().LongestIdealString("pvjcci",4));
//Console.WriteLine(new LongestIdealSubsequence().LongestIdealString("eduktdb",15));

/*int[][] edges = {
    new int[] {0,1},
    new int[] {1,2},
    new int[] {3,1},
     new int[] {0,4},
    new int[] {5,0}, 
    new int[] {6,5}, 
};

int[][] edges2 = {
    new int[] {0,1},
    new int[] {0,2},
    new int[] {0,5},
     new int[] {2,3},
    new int[] {4,0}, 
    new int[] {5,6}, 
};*/

//Console.WriteLine(new MaxReachableNodesWithRestriction().MaxNodes(7,edges,new int[]{4,5}));
//Console.WriteLine(new MaxReachableNodesWithRestriction().MaxNodes(7,edges2,new int[]{1,2,4}));

//Console.WriteLine(new CheckValidPartition().ValidPartition(new int[]{803201,803201,803201,803201,803202,803203}));
//Console.WriteLine(new CheckValidPartition().ValidPartition(new int[]{1,1,1,2}));
//Console.WriteLine(new SpecialIntegers().SpecialIntegerCount(20));

//

/*int[][] grid2 = {
    new int[] {1,1,1,1,1},
    new int[] {1,1,1,1,1},
    new int[] {1,1,2,1,1},
    new int[] {1,1,1,1,1},
    new int[] {1,1,1,1,1},
    
};*/

//Console.WriteLine(new MaxLocal().MaxLocalGrid(grid2));

//Console.WriteLine(new ConstructSmallestNumberFromDIString().SmallestNumber("IIII"));
//Console.WriteLine(new ConstructSmallestNumberFromDIString().SmallestNumber("DDD"));
//

//Console.WriteLine(new SpecialIntegers().SpecialIntegerCount(20));
//Console.WriteLine(new SpecialIntegers().SpecialIntegerCount(9));

//Console.WriteLine(new LongestSubstringWithoutRepeatingCharacter().LengthOfLongestSubstring("abba"));
//Console.WriteLine(new LongestPalindrome().LongestPalindromeString("a"));
//Console.WriteLine(new IsomorphicString().IsIsomorphic("badc", "baba"));
//Console.WriteLine(new TopKFrequentWords().TopKFrequent(new string[]{"i","love","leetcode","i","love","coding"},3));
//Console.WriteLine(new DecodeString().DecodedString("100[leetcode]"));
//Console.WriteLine(new DecodeString().DecodedString("3[a]2[bc]"));
//Console.WriteLine(new Fibonacci().Fib(4));

//Console.WriteLine(new BackspaceStringCompare().BackspaceCompare("a#c", "b"));
//Console.WriteLine(new LastStoneWeight().LastWeight(new int[]{2,2}));
//Console.WriteLine(new BullsAndCows().GetHint("1807","7810"));
//Console.WriteLine(new LongestPalindrome2().LongestPalingdromeLength("abccccdd"));
//Console.WriteLine(new BinarySearch().Search(new int[]{5},5));

/*TreeNode node5 = new TreeNode(5);
TreeNode node1 = new TreeNode(1);
TreeNode node4 = new TreeNode(4);
TreeNode node3 = new TreeNode(3);
TreeNode node6 = new TreeNode(6);
TreeNode node7 = new TreeNode(7);

node5.left = node4;
node5.right = node6;
node6.left = node3;
node6.right = node7;

//Console.WriteLine(new ValidateBinarySearchTree().IsValidBST(node5));
//Console.WriteLine(new UniqueSumToZero().SumZero(6));

int[][] dungeon = {
    new int[] {-2,-3,3},
    new int[] {-5,-10,1},
    new int[] {10,30,-5}
};

int[][] dungeon = {
    new int[] {-3,5}
};


//Console.WriteLine(new DungeonGame().CalculateMinimumHP(dungeon));

LeetCode.Problems.Trie trie = new LeetCode.Problems.Trie();
trie.Insert("apple");
Console.WriteLine(trie.Search("apple"));
Console.WriteLine(trie.Search("app"));
Console.WriteLine(trie.StartsWith("app"));
//Console.WriteLine(new FloodFill().FloodFillImage(image,1,1,2));
//Console.WriteLine(new MinCostStairs().MinCostClimbingStairs(new int[]{10,15,20}));
//Console.Write(new PossibleAnagrams().FindAnagrams("cbaebabacd","abc"));

//new ArrayInsertSort().Sort();
//new LongestRepeatingCharacterReplacement().characterReplacement("ABAB",2);

int[][] movesA = {
    new int[] {0,0},
    new int[] {2,0},
    new int[] {1,1},
    new int[] {2,1},
    new int[] {2,2}
};


int[][] movesB = {
    new int[] {0,0},
    new int[] {1,1},
    new int[] {0,1},
    new int[] {0,2},
    new int[] {1,0},
    new int[] {2,0}
};

int[][] movesDraw = {
    new int[] {0,0},
    new int[] {1,1},
    new int[] {2,0},
    new int[] {1,0},
    new int[] {1,2},
    new int[] {2,1},
    new int[] {0,1},
    new int[] {0,2},
    new int[] {2,2},
};

Console.WriteLine(new TicTacToe().TictactoeGame(movesDraw));*/

Console.Write(new MaxSubarray().MaxSubArrayTotal(new int[]{1}));