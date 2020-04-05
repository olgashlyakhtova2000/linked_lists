using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linked_list_2
{
    class MyLinkedList: IEnumerable
    {
        public Node head;
        public Node tail;
        public int count;

        public MyLinkedList ()
        {
            head = null;
        }
        public void AddLast (int element)
        {
            Node node = new Node(element);
            if (head == null)
            {
                head = node;
            }
            else tail.Next = node;
            tail = node;
            count++;
        }
        public void AddFirst (int element)
        {
            Node node = new Node(element);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }
            if (count==0)
            {
                head = tail;
            }
            count++;
        }
        public void Insert (int P, int element)
        {
            Node node = new Node(element);
            if (head==null||P>=count)
            {
                AddLast(element);
            }
            else
            {
                Node curr = head;
                Node curr1 = head;
                for (int i = 0; i<P; i++)
                {
                    curr1 = curr;
                    curr = curr.Next;
                }
                curr1.Next = node;
                node.Next = curr;
                count++;
            }
        }
        public void Remove (int P)
        {
            if (count==0||P>count)
            {
                Console.WriteLine(default(int));
            }
            else
            {
                count--;
                if (P==0)
                {
                    head = head.Next;
                }
                else 
                {
                    Node  curr = head;
                    for (int i =0; i<P-1&&curr!=null;i++)
                    {
                        curr = curr.Next;
                    }
                    curr.Next = curr.Next.Next;
                    if (curr.Next==null)
                    {
                        tail = curr;
                    }
                }
            }
        }
        public int Last()
        {
            if (count != 0) return tail.Data;
            else return default(int);
        }
        public int First ()
        {
            if (count == 0) return default(int);
            else return head.Data;
        }
        public void Clear ()
        {
            head.Next = null;
            count = 0;

        }
        public int Size ()
        {
            return count;
        }
        public int IndexOf(int element)
        {
            Node curr = head;
            for (int i = 0; i<count; i++)
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
            Node curr = head;
            for (int i = 0; i<Size(); i++)
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
                Node current = head;
                for (int i = 0; i < key && current != null; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                Node current = head;
                current.Data = value;
            }

        }
    }
}
