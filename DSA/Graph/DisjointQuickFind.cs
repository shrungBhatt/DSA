using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class DisjointQuickFind
    {
        //The index of this root represents the vertex
        //The root[i] represents the root node of that vertex
        public int[] root;

        public DisjointQuickFind(int size)
        {
            root = new int[size];
            //Set all of the root node to self
            for(int i = 0; i < size; i++)
            {
                root[i] = i;
            }
        }

        //The method that returns the root node of the given vertex x
        public int Find(int x)
        {
            return root[x];
        }

        //Sets the root node of y is set to root node of x if they are different
        public void Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);

            //Check if the value of rootx and rooty is same or different
            if(rootX != rootY)
            {
                //For all the vertex in the array having root[i] == rootY, set root[i] == rootX
                for(int i = 0; i < root.Length; i++)
                {
                    if(root[i] == rootY)
                    {
                        root[i] = rootX;
                    }
                }
            }
        }

        //Method used to check whether the given graph vertex are connected or not
        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }

    }
}
