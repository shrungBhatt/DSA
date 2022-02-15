using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class DisjointQuickUnion
    {
        int[] root;

        public DisjointQuickUnion(int size)
        {
            root = new int[size];
            //Set all the root[i] to itself
            for(int i = 0; i < size; i++)
            {
                root[i] = i;
            }
        }

        //The root[i] represents the parent of current indexed vertex. So we iterate till we find a root node. For a root node the root[i] == index value
        public int Find(int x)
        {
            while(root[x] != x)
            {
                x = root[x];
            }
            return x;
        }

        public void Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);

            if(rootX != rootY)
            {
                root[y] = rootX;
            }
        }

        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}
