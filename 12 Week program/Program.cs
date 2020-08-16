using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using _12_Week_program.Stack;
using LinkedList;
namespace _12_Week_program
{
    public class Program
    {
        public static string RestoreString(string s, int[] indices)
        {
            char[] result = new char[indices.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                result[indices[i]] = s[indices[i]];
            }
            return string.Join("",result);
        }
        public static string RankTeams(string[] votes)
        {
            Dictionary<char, double> teamScore = new Dictionary<char, double>();
            int n = votes[0].Length, power = 1000;
            foreach (string s in votes)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    char team = s[i];
                    if (teamScore.ContainsKey(team)) teamScore[team] += Math.Pow(power, n - i);
                    else teamScore[team] = Math.Pow(power, n - i);
                }
            }
            IEnumerable<char> cc = teamScore.Keys.OrderByDescending(x => teamScore[x]).ThenBy(x => x);//sort by assign value, then by team name
            return new string(cc.ToArray());
        }
        public static void Main(string[] args)
        {
            var x = Program.RankTeams(new string[] { "BCA", "CAB", "CBA", "CAB", "ACB", "BAC" });
            //QuickSortAlgo qs = new QuickSortAlgo();
            //int[] nums = new int[] { -2,3,-5 };
            //Program.quickSort(nums,0,nums.Length-1);
            //var x=nums.Length;

        }
        static int partition(int[] arr, int low,
                                   int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
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
    
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
}
