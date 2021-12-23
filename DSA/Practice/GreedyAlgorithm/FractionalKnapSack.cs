using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.GreedyAlgorithm
{
    internal class FractionalKnapSack
    {
        internal int Calculate(List<Item> items, int maxWeight)
        {
            var ordered = items.OrderByDescending(x => x.Ratio).ToList();
            var sackWeight = 0;
            var amount = 0;
            var index = 0;

            while (sackWeight != maxWeight)
            {
                if (ordered[index].Weight + sackWeight < maxWeight)
                {
                    sackWeight += ordered[index].Weight;
                    amount += ordered[index].Value;
                    index++;
                }
                else
                {
                    var remainWeight = maxWeight - sackWeight;
                    var fractionalAmount = (remainWeight * ordered[index].Value) / ordered[index].Weight;
                    amount += fractionalAmount;
                    sackWeight += remainWeight;
                }
            }

            return amount;

        }
    }

    internal class Item
    {
        internal int Weight;
        internal int Value;
        internal int Ratio
        {

            get
            {
                if (Value != 0) return Value / Weight;
                else return 0;
            }
        }
    }
}
