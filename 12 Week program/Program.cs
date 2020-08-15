using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using _12_Week_program.Stack;
using LinkedList;
namespace _12_Week_program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string[] a = new string[]{ "a","b","a","c","d"};

            //char[][] c ={
            //    new char[]{'A', 'B', 'C', 'E' },
            //    new char[]{'S', 'F', 'C', 'S' }, 
            //    new char[] { 'A', 'D', 'E', 'E' } 
            //};
            char[][] c =
            {
                new char[]{'a','a'}
            };
            //var b= a.GroupBy(x => x);
            //var c = b.Select(x => x.Key); 
            var a = Program.Exist(c,"aa");
            //MinStack m = new MinStack();
            //m.Push(5);
            //m.Push(-2);
            //m.Push(3);
            //m.Push(6);
            //m.Pop();
            //Console.WriteLine(m.GetMin());
            //m.Pop();
            //Console.WriteLine(m.GetMin());
            //m.Pop();
            //Console.WriteLine(m.GetMin());


        }
        //public static bool Exist(char[][] board, string word)
        //{
        //    char[] x = word.ToCharArray();
        //    var wordSearch = new List<char>();

        //    for (int k = 0; k < x.Length; k++)
        //    {
        //        bool stop = false;
        //        for (int i = 0; i < board.Length&& !stop; i++)
        //        {
        //            for (int j = 0; j < board[i].Length &!stop; j++)
        //            {
        //                var m = x[k];
        //                if (x[k] == board[i][j])
        //                {
        //                    if (wordSearch.Contains(x[k]) && (wordSearch
        //                       ?.GroupBy(x => x)
        //                       ?.Where(x => x.Key == m)
        //                       ?.FirstOrDefault().Count() ?? 0) - 1 == i)
        //                        break;
        //                    else
        //                    {
        //                        wordSearch.Add(x[k]);
        //                       stop=true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return word == new String(wordSearch.ToArray());
        //}
        public static bool Exist(char[][] board, string word)
        {
            char[] x = word.ToCharArray();
            var r = board.SelectMany(x => x).ToArray();
            var first = x.GroupBy(x => x);
            var secind = r.GroupBy(a => a);
            var h = first.Select(y => (secind?.Where(b => b.Key == y.Key)?.FirstOrDefault()?.Count() ?? 0) >= y.Select(c => c).Count()).ToList();
            var isTrue = h.All(m => m);
            return isTrue;
        }
        public static void display(MyLinkedList list)
        {
            var temp = list.Root;
            while (temp != null)
            {
                Console.Write($"{temp.Data}->");
                //Console.Write($"{temp.Next?.Data ?? 0}");
                temp = temp.Next;
                //Console.WriteLine();
            }
            Console.Write("null");
            Console.WriteLine();
        }
    }
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
        for (lvl = 0; lvl < Length; lvl++)
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
}
