using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.ArrayStrings
{
    internal class IsUnique
    {
        internal bool HasUniqueCharacters(string word)
        {
            var charSet = new HashSet<char>();
            foreach(var character in word)
            {
                if (charSet.Contains(character))
                {
                    return false;
                }
                else
                {
                    charSet.Add(character);
                }

            }
            
            return true;
        }
    }
}
