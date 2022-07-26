namespace LeetCode.Problems.Utils;

public class Trie{

    private TrieNode root;

    public Trie(TrieNode root){
        this.root = root;
    }

    public void Insert(string word){
        TrieNode node = root;

        foreach(char ch in word){
            if(!node.ContainsKey(ch)){
                node.Add(ch, new TrieNode());
            }
            node = node.Get(ch);
        }
        node.SetComplete();
    }

    public bool Search(string word){

        TrieNode node = root;
        var tmp = "";

        foreach(char ch in word){
            if(node.ContainsKey(ch)){
                node = node.Get(ch);
                tmp += ch;
            }
        }

        if(node != null && node.IsComplete() && tmp == word){
            return true;
        }else{
            return false;
        }
    }

}

public class TrieNode {

    private Dictionary<char, TrieNode> children;
    private bool isComplete;
    private int count;

    public TrieNode(){
        children = new Dictionary<char, TrieNode>();
    }

    public bool ContainsKey(char ch){
        return children.ContainsKey(ch);
    }

    public bool IsComplete(){
        return this.isComplete;
    }

    public void SetComplete(){
        this.isComplete = true;
    }

    public void Add(char ch, TrieNode node){
        children[ch] = node;
    }

    public TrieNode Get(char ch){
        return children[ch];
    }

}