using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.ArrayStrings
{
    internal class URLify
    {
        internal string ConvertUrl(string word, int trueLength)
        {
            //word = "Mr John Smith    "
            var totalSpaces = CountTotalSpaces(word, trueLength); //trueLength = 13, totalSpaces = 2
            var charArray = word.ToArray();
            var index = trueLength + (2 * totalSpaces); //index = 17
            for(int i = trueLength - 1; i >= 0; i--)
            {
                if(charArray[i] == ' ')// i = 12
                {
                    charArray[index - 1] = '0';
                    charArray[index - 2] = '2';
                    charArray[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    charArray[index - 1] = charArray[i];
                    index -= 1;
                }
            }

            return new string(charArray);
        }

        int CountTotalSpaces(string word, int trueLength)
        {
            int count = 0;
            word = word.Trim();
            for(int i = 0; i < trueLength; i++)
            {
                if(word[i] == ' ')
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
