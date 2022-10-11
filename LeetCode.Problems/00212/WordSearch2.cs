namespace LeetCode.Problems;


public class TrieNode {
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public string word = null;

    public TrieNode(){}
}

public class WordSearch2{

    List<string> results = new List<string>();
    public IList<string> FindWords(char[][] board, string[] words) {

        //construct Trie using the words array
        TrieNode root = new TrieNode();
        foreach(string word in words){
            TrieNode node = root;

            foreach(char ch in word){
                if(node.children.ContainsKey(ch)){
                    node = node.children[ch];
                }else{
                    TrieNode newnode = new TrieNode();
                    node.children.Add(ch, newnode);
                    node = newnode;
                }
            }
            node.word = word;
        }

        for(int i=0; i < board.Length; i++){
            for(int j=0; j < board[0].Length; j++){
                if(root.children.ContainsKey(board[i][j])){
                    find(board, root, i,j);
                }
            }
        }

        return results;
    }

    private void find(char[][] board, TrieNode node, int row, int col){

        char letter = board[row][col];
        TrieNode currNode = node.children[letter];

        if(currNode.word != null){
            results.Add(currNode.word);
            currNode.word = null;
        }

        board[row][col] = '#';

        int[] rowOffset = {-1,0,1,0};
        int[] colOffset = {0,1,0,-1};

        for(int i=0 ;i<4; i++){
            int newRow = row + rowOffset[i];
            int newCol = col + colOffset[i];

            if(newRow < 0 || newRow >= board.Length || newCol <0 || newCol>=board[0].Length){
                continue;
            }

            if(currNode.children.ContainsKey(board[newRow][newCol])){
                find(board, currNode, newRow, newCol);
            }
        }

        board[row][col] = letter;
    }
}