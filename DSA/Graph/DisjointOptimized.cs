using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class DisjointOptimized
    {
        int[] root;
        int[] rank;

        public DisjointOptimized(int size)
        {
            root = new int[size];
            rank = new int[size];

            for(int i = 0; i < size; i++)
            {
                root[i] = i;
                rank[i] = i;
            }
        }

        public int Find(int x)
        {
            if(root[x] == x)
            {
                return x;
            }

            return root[x] = Find(root[x]);
        }

        public void Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);

            if(rootX != rootY)
            {
                if(rank[rootX] > rank[rootY])
                {
                    root[rootY] = rootX;
                }
                else if(rank[rootX] < rank[rootY])
                {
                    root[rootX] = rootY;
                }
                else
                {
                    root[rootY] = rootX;
                    rank[rootX] += 1;
                }
            }
        }

        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}
