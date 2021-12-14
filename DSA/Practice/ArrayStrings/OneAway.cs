using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.ArrayStrings
{
    internal class OneAway
    {
        internal bool OneEditAway(string word1, string word2)
        {
            if(word1.Length == word2.Length)
            {
                return OneReplaceAway(word1, word2);
            }
            else if(word1.Length + 1 == word2.Length)
            {
                return OneInsertAway(word1, word2);
            }
            else if(word2.Length - 1 == word2.Length)
            {
                return OneInsertAway(word2, word1);
            }
            return false;
        }

        bool OneReplaceAway(string word1, string word2)
        {
            bool differenceFound = false;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                {
                    if (differenceFound)
                    {
                        return false;
                    }
                    differenceFound = true;
                }
            }
            return true;
        }

        bool OneInsertAway(string word1, string word2)
        {
            var index1 = 0;
            var index2 = 0;
            while(index1 < word1.Length && index2 < word2.Length)
            {
                if(word1[index1] != word2[index2])
                {
                    if(index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }

            return true;
        }
    }
}
