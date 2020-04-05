using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_2
{
    class DoubleNode
    {
        public DoubleNode(int element)
        {
            Data = element;
        }
        public int Data;
        public DoubleNode Previous;
        public DoubleNode Next;
    }
}
