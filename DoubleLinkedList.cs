using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linked_list_2
{
    class DoubleLinkedList : IEnumerable
    {
        DoubleNode head;
        DoubleNode tail;
        public int count;

        public DoubleLinkedList()
        {
            head = null;
        }
        public void AddLast(int element)
        {
            DoubleNode node = new DoubleNode(element);
            if (head==null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Next = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst (int element)
        {
            DoubleNode node = new DoubleNode(element);
            DoubleNode node1 = head;
            node.Next = node1;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            else node1.Previous = node;
            count++;
        }
        public void Insert (int P, int element)
        {
           
            if (P<0||P>count)
            {
                throw new InvalidOperationException();
            }
            else if (head==null||P==count)
            {
                AddLast(element);
            }
            else if(P==0)
            {
                AddFirst(element);
            }
            else if (P>0&&P<count)
            {
                DoubleNode node = new DoubleNode(element);
                uint count1 = 0;
                DoubleNode current = head;
                //while (current!=null&&count1!=P)
                //{
                //    current = current.Next;
                //    count1++;
                //}
                //current.Previous.Next = node;
                //node.Previous = current.Previous;
                //current.Previous = node;
                //node.Next = current;
                DoubleNode curr = head;
                DoubleNode curr1 = head;
                for (int i = 0; i < P; i++)
                {
                    curr1 = curr;
                    curr = curr.Next;
                }
                curr.Previous = node;
                node.Previous = curr1;
                node.Next = curr;
                curr1.Next = node;
                count++;
            }
            
        }
        public void Remove (int P)
        {
            if (count == 0 || P > count)
            {
                Console.WriteLine(default(int));
            }
            else
            {
                count--;
                if (P==0)
                {
                    head = head.Next;
                    head.Previous = null;
                }
                else
                {
                    DoubleNode curr = head;
                    for (int i = 0; i < P - 1 && curr != null; i++)
                    {
                        curr = curr.Next;
                    }
                    curr.Next = curr.Next.Next;

                    if (curr.Next == null)
                    {
                        tail = curr;
                    }
                }
            } 
        }
        public int Last()
        {
            if (count==0) return default(int);
            else return tail.Data;
            
        }
        public int First()
        {
            if (count == 0) return default(int);
            else return head.Data;

        }
        public void Clear()
        {
            head.Next = null;
            count = 0;

        }
        public int Size()
        {
            return count;
        }
        public int IndexOf(int element)
        {
            DoubleNode curr = head;
            for (int i = 0; i < count; i++)
            {
                if (curr.Data == element)
                {
                    return i;
                }
                curr = curr.Next;
            }
            return -1;
        }
        public IEnumerator GetEnumerator()
        {
            DoubleNode curr = head;
            for (int i = 0; i < Size(); i++)
            {
                yield return curr.Data;
                curr = curr.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int this[int key]
        {
            get
            {
                DoubleNode current = head;
                for (int i = 0; i < key && current != null; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                DoubleNode current = head;
                current.Data = value;
            }

        }
    }
}
