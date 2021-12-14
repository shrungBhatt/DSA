using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.ArrayStrings
{
    internal class StringCompression
    {
        internal string CompressString(string word)
        {
            //The string has consecutive repitive letters
            //Ex. aabcccccaaa
            //The output should be a2b1c5a3
            //The letters are lower case or upper case a or A [a - z]
            //If the length of the compressed string is greater than original string, return the original string
            if (word != null)
            {
                if (word.Length > 0)
                {
                    char currentChar = word[0];
                    int count = 1;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < word.Length; i++)
                    {
                        if(currentChar == word[i])
                        {
                            count++;
                        }
                        else
                        {
                            sb.Append(currentChar);
                            sb.Append(count);
                            currentChar = word[i];
                            count = 1;
                        }
                    }

                    //Append the last repititive character.
                    sb.Append(currentChar);
                    sb.Append(count);

                    return sb.ToString().Length > word.Length ? word : sb.ToString();
                }
                else
                {
                    throw new ArgumentNullException("The word cannot be null");
                }
            }
            return string.Empty;

        }
    }
}
