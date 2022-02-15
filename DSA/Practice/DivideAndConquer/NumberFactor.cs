using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.DivideAndConquer
{
    internal class NumberFactor
    {                                       
        internal int FactorsOfN(int n)
        {
            if ((n == 0) || (n == 1) || (n == 2))
            {
                return 1;
            }

            if(n == 3)
            {
                return 2;
            }

            int sub1 = FactorsOfN(n - 1);
            int sub2 = FactorsOfN(n - 3);
            int sub3 = FactorsOfN(n - 4);

            return sub1 + sub2 + sub3;
        }
    }
}
