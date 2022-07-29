namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class WordSearchTrie{

    Trie _trie;

    public WordSearchTrie(){
        _trie = new Trie(new TrieNode());
    }

    public WordSearchTrie(string[] dict){
        _trie = new Trie(new TrieNode());

        foreach(string str in dict){
            _trie.AddEntry(str);
        }
    }

    


}