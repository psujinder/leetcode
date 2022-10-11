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

//Console.Write(new MaxSubarray().MaxSubArrayTotal(new int[]{1}));

//new MergeSortedArray().Merge(new int[]{1,2,3,0,0,0}, 3, new int[]{2,5,6}, 3);

//new IntersectionOfTwoArraysII().Intersect(new int[]{1,2,2,1}, new int[]{2,2});

/*int[][] arr = {
    new int[] {1,2},
    new int[] {3,4}
};

new ReshapeMatrix().MatrixReshape(arr,1,4);*/

//new PascalsTriangle().Generate(5);

//new FirstUniqueCharacter().FirstUniqChar("aabb");

//new SortPeople().Sort(new string[]{"Mary","John","Emma"}, new int[]{180,165,170});

//new LongestSubarrayBitwiseAnd().LongestSubarray(new int[]{1,2,3,3,2,2});

//new FindAllGoodIndices().GoodIndices(new int[]{693570,409751,33944,16682,26296,545257,827687,885741,970671},3);

int[][] flights1 = {
    new int[] {0,1,100},
    new int[] {1,2,100},
    new int[] {2,0,100},
    new int[] {1,3,600},
    new int[] {2,3,200},
};

//Console.WriteLine(new CheapestFlightsWithinKStops().FindCheapestPrice(4, flights1, 0,3,1));

int[][] flights2 = {
    new int[] {3,4,4},
    new int[] {2,5,6},
    new int[] {4,7,10},
    new int[] {9,6,5},
    new int[] {7,4,4},
    new int[] {6,2,10},
    new int[] {6,8,6},
    new int[] {7,9,4},
    new int[] {1,5,4},
    new int[] {1,0,4},
    new int[] {9,7,3},
    new int[] {7,0,5},
    new int[] {6,5,8},
    new int[] {1,7,6},
    new int[] {4,0,9},
    new int[] {5,9,1},
    new int[] {8,7,3},
    new int[] {1,2,6},
    new int[] {4,1,5},
    new int[] {5,2,4},
    new int[] {1,9,1},
    new int[] {7,8,10},
    new int[] {0,4,2},
    new int[] {7,2,8},
};

//Console.WriteLine(new CheapestFlightsWithinKStops().FindCheapestPrice(10, flights2, 6,0,7));

int[][] edges = {
    new int[] {0,1},
    new int[] {1,2},
    new int[] {2,3},
    new int[] {1,3},
    new int[] {1,4},
};


//Console.WriteLine(new GraphValidTree().ValidTree(5,edges));
//Console.WriteLine(new GraphValidTree().ValidTree(5,edges));



//Console.WriteLine(new NumberofProvinces().FindCircleNum(isConnected));

int[][] grid = {
    new int[] {0,0,1,0,0,0,0,1,0,0,0,0,0},
    new int[] {0,0,0,0,0,0,0,1,1,1,0,0,0},
    new int[] {0,1,1,0,1,0,0,0,0,0,0,0,0},
    new int[] {0,1,0,0,1,1,0,0,1,0,1,0,0},
    new int[] {0,1,0,0,1,1,0,0,1,1,1,0,0},
    new int[] {0,0,0,0,0,0,0,0,0,0,1,0,0},
    new int[] {0,0,0,0,0,0,0,1,1,1,0,0,0},
    new int[] {0,0,0,0,0,0,0,1,1,0,0,0,0}
};

//Console.WriteLine(new MaxAreaIsland().MaxAreaOfIsland(grid));

int[][] closedGrid = {
    new int[] {1,1,1,1,1,1,1,0},
    new int[] {1,0,0,0,0,1,1,0},
    new int[] {1,0,1,0,1,1,1,0},
    new int[] {1,0,0,0,0,1,0,1},
    new int[] {1,1,1,1,1,1,1,0}
};

//Console.WriteLine(new NumberOfClosedIslands().ClosedIsland(closedGrid));

int[][] enclave = {
    new int[] {0,0,0,0},
    new int[] {1,0,1,0},
    new int[] {0,1,1,0},
    new int[] {0,0,0,0}
};

//Console.WriteLine(new NumerOfEnclaves().NumEnclaves(enclave));

int[][] connected = {
    new int[]{0,1},
    new int[]{1,2},
    new int[]{2,3},
    new int[]{3,4}
};

//Console.WriteLine(new NumberOfConnectedComponents().CountComponents(5,connected));

int[][] states = {
    new int[]{1,2},
    new int[]{2,3},
    new int[]{5},
    new int[]{0},
    new int[]{5},
    new int[]{},
    new int[]{}
};

int[][] states2 = {
    new int[]{1,2,3,4},
    new int[]{1,2},
    new int[]{3,4},
    new int[]{0,4},
    new int[]{}
};

int[][] states3 = {
    new int[]{},
    new int[]{0,2,3,4},
    new int[]{3},
    new int[]{4},
    new int[]{}
};

//Console.WriteLine(new EventualSafeStates().EventualSafeNodes(states));

int[][] dungeon = {
    new int[]{-2,-3,3},
    new int[]{-5,-10,1},
    new int[]{10,30,-5}
};

//Console.WriteLine(new DungeonGame().CalculateMinimumHP(dungeon));

//Console.WriteLine(new RemoveDigitFromNumber().RemoveDigit("2464",'6'));
//Console.WriteLine(new ThreeSums().ThreeSum(new int[]{-1,0,1,2,-1,-4}));
//Console.WriteLine(new EqualSumArrayWithMinOperations().MinOperations(new int[]{1,2,3,4,5,6}, new int[]{1,1,2,2,2,2}));
//Console.WriteLine(new EqualSumArrayWithMinOperations().MinOperations(new int[]{1,2,3,4,5,6}, new int[]{6}));
//Console.WriteLine(new EqualSumArrayWithMinOperations().MinOperations(new int[]{6,6}, new int[]{1}));
//Console.WriteLine(new Combinations().Combine(4,2));
//Console.WriteLine(new Permutations().Permute(new int[]{1,2,3}));
//Console.WriteLine(new LetterCasePermutation().LetterCasePermute("a1b2"));
//Console.WriteLine(new LetterCasePermutation().LetterCasePermute("3z4bc"));
//Console.WriteLine(new HouseRobber().Rob(new int[]{2,1,1,2}));

int[][] triangle = {
    new int[]{2},
    new int[]{3,4},
    new int[]{6,5,7},
    new int[]{4,1,8,3}
};

//Console.WriteLine(new Triangle().MinimumTotal(triangle));

//Console.WriteLine(new Subsets().Subset(new int[]{3,2,4,1}));

//Console.WriteLine(new Subsets2().SubsetsWithDup(new int[]{1,2,2}));

//Console.WriteLine(new Permutations2().PermuteUnique(new int[]{1,1,2}));

//Console.WriteLine(new CombinationSum().CombSum(new int[]{2,3,6,7}, 7));

//Console.Write(new ValidPalindrome().IsPalindrome(".,"));
//Console.WriteLine(new Atoi().MyAtoi2("2147483648"));

/*ListNode l1_1 = new ListNode();
l1_1.val = 2;

ListNode l1_2 = new ListNode();
l1_2.val = 4;

ListNode l1_3 = new ListNode();
l1_3.val = 3;

l1_1.next = l1_2;
l1_2.next = l1_3;

ListNode l2_1 = new ListNode();
l2_1.val = 5;

ListNode l2_2 = new ListNode();
l2_2.val = 6;

ListNode l2_3 = new ListNode();
l2_3.val = 4;

l2_1.next = l2_2;
l2_2.next = l2_3;

ListNode ArrayToList(int[] arr, bool isReverse){
    
    ListNode lst = new ListNode();
    ListNode head = lst;

    if(!isReverse){
        for(int i=0; i< arr.Length-1; i++){
            lst.val = arr[i];
            lst.next = new ListNode();
            lst = lst.next;
        }
        lst.val = arr.Last();
    }else{
        for(int i=arr.Length-1; i> 0; i--){
            lst.val = arr[i];
            lst.next = new ListNode();
            lst = lst.next;
        }
        lst.val = arr.First();
    }
    return head;
}


//Console.WriteLine(new AddTwoNumbers().AddTwoNums(ArrayToList(new int[]{9,9,9,9,9,9,9}), ArrayToList(new int[]{9,9,9,9})));
//Console.WriteLine(new AddTwoNumbers().AddTwoNums(ArrayToList(new int[]{2,4,3}, false), ArrayToList(new int[]{5,6,4},false)));
//Console.Write(new CoinChange2Problem().CoinChange(11,new int[]{1,2,5}));
//Console.Write(new CoinChangeProblem().CoinChange(new int[]{186,419,83,408},6249));
//Console.WriteLine(new CoinChange2Problem().CoinChange(500, new int[]{1,2,5}));
//Console.WriteLine(new MinimumDeletionsUniqueString().MinDeletions("bbcebab"));
//Console.WriteLine(new LongestHappyString().LongestDiverseString(2,2,1));*/
//Console.WriteLine(new PhoneNumberCombination().LetterCombinations("2345"));

char[][] board = {
    new char[]{'o','a','n','n'},
    new char[]{'e','t','a','e'},
    new char[]{'i','h','k','r'},
    new char[]{'i','f','l','v'}
};

char[][] board2= {
    new char[]{'o','a','b','n'},
    new char[]{'o','t','a','e'},
    new char[]{'a','h','k','r'},
    new char[]{'a','f','l','v'}
};

char[][] board3= {
    new char[]{'a','b'}
};

//Console.WriteLine(new WordSearch2().FindWords(board3, new string[]{"ba"}));

//Console.WriteLine(new WildcardMatching().IsMatch("ererer","a******bc*****c"));
//new SortColorsProblem().SortColors2(new int[]{1,2,0});
//Console.WriteLine(new MinInRotatedSortedArray().FindMin(new int[]{11,13,15,17}));

int[][] matrix = {
    new int[]{1,3,5,7},
    new int[]{10,11,16,20},
    new int[]{23,30,34,60}
};

int[][] matrix2 = {
    new int[]{1,3}
};

int[][] matrix3 = {
    new int[]{1},
    new int[]{3},
};

//Console.WriteLine(new Search2DMatrix().SearchMatrix(matrix3, 2));
//Console.WriteLine(new SearchInRotatedSortedArray().Search(new int[]{4,5,6,7,0,1,2},0));
//Console.WriteLine(new SearchInRotatedSortedArray().Search(new int[]{1,3},3));
Console.WriteLine(new SearchInRotatedSortedArray().Search(new int[]{4,5,6,7,8,1,2},8));