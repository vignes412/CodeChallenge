/*
 * @lc app=leetcode id=208 lang=csharp
 *
 * [208] Implement Trie (Prefix Tree)
 */

// @lc code=start
    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public bool isEndOfWord;
        public TrieNode()
        {
        for(int i =0;i<26;i++)
        {
            children[i]=null;
        }
    }
}
public class Trie
{

    public TrieNode root;
    /** Initialize your data structure here. */
    public Trie()
    {
        root=new TrieNode();
    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
    {
        int level;
        int length = word.Length;
        int index;
        TrieNode pCrawl = root;
        for (level = 0; level < length; level++)
        {
            index = word[level] - 'a';
            if (pCrawl.children[index] == null)
                pCrawl.children[index] = new TrieNode();
            pCrawl = pCrawl.children[index];
        }
        pCrawl.isEndOfWord = true;
    }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
    {
        int lvl;
        int length = word.Length;
        int index;
        TrieNode pCrawl = root;
        for (lvl = 0; lvl < length; lvl++)
        {
            index = word[lvl] - 'a';
            if (pCrawl.children[index] == null)
                return false;
            pCrawl = pCrawl.children[index];
        }
            return (pCrawl != null && pCrawl.isEndOfWord);
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix)
    {
        int lvl;
        int pLength = prefix.Length;
        int index;
        TrieNode pCrawl = root;
        for (lvl = 0; lvl < pLength; lvl++)
        {
            index = prefix[lvl] - 'a';
            if (pCrawl.children[index] == null)
                return false;
            pCrawl = pCrawl.children[index];
        }
        return true;
    }
}
/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

