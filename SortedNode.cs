using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_2
{
    class SortedNode
    {
        public int key = 0;
        public string value;
        public SortedNode Next;

        public SortedNode(int k, string message)
        {
            key = k;
            value = message;
        }
    }
}
