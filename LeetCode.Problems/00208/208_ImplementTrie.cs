namespace LeetCode.Problems;

/*public class TrieNode {
    
    private Dictionary<char, TrieNode> children;
    private bool isEnd;

    public TrieNode(){
        children = new Dictionary<char, TrieNode>();
    }

    public bool ContainsKey(char ch){
        return children.ContainsKey(ch);
    }

    public TrieNode Get(char ch){
        return children[ch];
    }

    public void Add(char ch, TrieNode node){
        children[ch] = node;
    }

    public bool IsEnd(){
        return this.isEnd;
    }

    public void SetIsEnd(bool isEnd){
        this.isEnd = isEnd;
    }
}

public class Trie{

    public TrieNode root;

    public Trie(){
        root = new TrieNode();
    }

    public void Insert(string word){

        TrieNode node = root;
        foreach(char ch in word){
            if(!node.ContainsKey(ch)){
                node.Add(ch, new TrieNode());
            }
            node = node.Get(ch);
        }
        node.SetIsEnd(true);

    }
    
    public bool Search(string word){
        
        TrieNode node = root;
        foreach(char ch in word){
            if (node.ContainsKey(ch)){
                node = node.Get(ch);
            }else{
                return false;
            }
        }

        return node != null && node.IsEnd();
    }

    public bool StartsWith(string prefix){
        TrieNode node = root;
        foreach(char ch in prefix){
            if (node.ContainsKey(ch)){
                node = node.Get(ch);
            }else{
                return false;
            }
        }

        return node != null;
    }
}*/