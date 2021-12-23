using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.GreedyAlgorithm
{
    internal class CoinChangeProblem
    {
        internal int CalculateMinChange(int[] denominations, int amount)
        {
            int count = 0;
            Array.Sort(denominations);
            var index = denominations.Length - 1;

            while (amount != 0)
            {
                if (index >= 0)
                {
                    var currentDenomination = denominations[index];
                    if (currentDenomination <= amount)
                    {
                        count++;
                        amount -= currentDenomination;
                    }
                    else
                    {
                        index--;
                    }
                }
                else
                {
                    break;
                }

            }

            return count;
        }
    }
}
