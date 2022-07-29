namespace LeetCode.Problems.Utils;

public class Trie{

    private TrieNode root;

    public Trie(TrieNode root){
        this.root = root;
    }

    public void AddEntry(string word){
        TrieNode node = root;

        foreach(char ch in word){
            if(!node.ContainsKey(ch)){
                node.Add(ch, new TrieNode());
            }
            node = node.GetChild(ch);
        }
        node.SetComplete();
    }

    public bool Search(string word){

        TrieNode node = root;
        
        foreach(char ch in word){
            if(node.ContainsKey(ch)){
                node = node.GetChild(ch);
                if(node.IsComplete()){
                    return true;
                }
            }
        }

        return false;
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

    public TrieNode GetChild(char ch){
        return children[ch];
    }

    public bool HasChild(char ch){
        
        bool hasChildern;

        hasChildern = children.Count > 0 ?  true:  false;
        
        return hasChildern;
    }

}