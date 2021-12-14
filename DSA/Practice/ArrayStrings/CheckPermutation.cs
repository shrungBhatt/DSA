using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.ArrayStrings
{
    internal class CheckPermutation
    {
        internal bool IsAPermutation(string word1, string word2)
        {
            return Sort(word1).Equals(Sort(word2));
        }

        string Sort(string word)
        {
            var tempArray = word.ToArray();
            Array.Sort(tempArray);
            return new string(tempArray);
        }
    }
}
