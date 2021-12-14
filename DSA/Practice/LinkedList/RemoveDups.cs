using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.LinkedList
{
    internal class RemoveDups
    {
        internal void RemoveDupItem(LinkedListNode<int> list)
        {
            var ll = new LinkedList<int>();
            
            var set = new HashSet<int>();
            while(list != null)
            {
                if (set.Contains(list.Value))
                {
                    list.List.Remove(list);
                    continue;
                }
                else
                {
                    set.Add(list.Value);
                }
                list = list.Next;
            }
        }

        internal void Print(LinkedList<int> list)
        {
            if (list != null)
            {
                var enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.Write($" {enumerator.Current} ");
                }
            }
        }
    }
}
