using System;
using System.Collections.Generic;

namespace DSA.Tree
{
    internal class TrieNode
    {
        internal Dictionary<char, TrieNode> Children { get; set; }
        internal bool IsEndOfWord { get; set; }

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
        }
    }

    internal class Trie
    {
        TrieNode root { get; set; }
        public Trie()
        {
            root = new TrieNode();
        }

        internal void Insert(string word)
        {
            //We start with the root first
            var currentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                var ch = word[i];
                var node = currentNode.Children[ch];
                if (node != null)
                {
                    node = new TrieNode();
                    node.Children.Add(ch, node);
                }
                currentNode = node;
            }
            currentNode.IsEndOfWord = true;
        }

        internal bool Search(string word)
        {
            var currentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                var ch = word[i];
                var node = currentNode.Children[ch];
                if (node == null)
                {
                    Console.WriteLine("The string does not exist in the trie");
                    return false;
                }
                currentNode = node;
            }

            if (currentNode.IsEndOfWord)
            {
                Console.WriteLine("The string exists in the trie");
            }
            else
            {
                Console.WriteLine("The prefix is present in the string but its not complete string");
            }

            return currentNode.IsEndOfWord;
        }

    }
}
