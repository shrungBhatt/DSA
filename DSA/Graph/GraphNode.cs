using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    internal class GraphNode
    {
        internal string Name { get; set; }
        internal int Index { get; set; }
        internal List<GraphNode> Neighbors = new List<GraphNode>();
        internal bool IsVisited { get; set; }

        public GraphNode(string name, int index)
        {
            Name = name;
            Index = index;
        }
    }
}
