using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.ArrayStrings
{
    internal class PalindromePermutation
    {

        internal bool IsPalindromePermutation(string word)
        {
            var map = new Dictionary<char, int>();
            word = word.ToLower();

            InitializeMap(ref map, word);
            return HasMaxOneOdd(ref map);
        }

        bool HasMaxOneOdd(ref Dictionary<char, int> map)
        {
            bool containsOdd = false;
            foreach (var key in map.Keys)
            {
                if (map[key] % 2 == 1)
                {
                    if (containsOdd)
                    {
                        return false;
                    }
                    containsOdd = true;
                }
            }
            return true;
        }

        void InitializeMap(ref Dictionary<char, int> map, string word)
        {
            foreach (var character in word)
            {
                if (map.ContainsKey(character))
                {
                    map[character] += 1;
                }
                else
                {
                    if (char.IsLetter(character))
                    {
                        map.Add(character, 1);
                    }
                }
            }
        }

    }
}
