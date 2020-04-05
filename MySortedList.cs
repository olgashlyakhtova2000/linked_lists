using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_2
{
    class MySortedList:IEnumerable, IComparable
    {
        SortedNode head;
        SortedNode tail;
        public int count = 0;
        int[] data = new int[1000];
        string[] s1 = new string[1000];

        public MySortedList()
        {
            head = null;
        }
        public bool Check(int [] array, int a)
        {
            int y = 0;
            for(int i = 0; i<count; i++)
            {
                if (array[i]==a)
                {
                    break;
                }
                y++;
            }
            if (y == count) return true;
            else return false;
            
        }
        public void Add (int k, string mess)
        {
            if (Check(data, k) == false)
            {
                throw new ArgumentException();
            }
            else
            {

                SortedNode node = new SortedNode(k, mess);
                data[count] = node.key;
                s1[count] = node.value;
                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    if (head.key > node.key)
                    {
                        node.Next = head;
                        tail = head;
                        head = node;
                    }
                    else if (head.key < node.key)
                    {

                        SortedNode curr = head;
                        SortedNode curr1 = head;

                        if (head == tail)
                        {
                            head.Next = node;
                            tail = node;
                        }
                        else if (node.key>tail.key)
                        {
                            tail.Next = node;
                            tail = node;
                        }
                        else
                        {
                            for (int i = 0; curr.key < node.key && curr.Next.key > node.key; i++)
                            {

                                curr1 = curr;
                                curr = curr.Next;
                            }
                            curr1.Next = node;
                            node.Next = curr;
                        }
                    }
                }
                //Sort(data);
                count++;
            }
        }
        public void Sort (int [] array)
        {
            int s = 1;
            int temp;
            string mess;
            for(int j = 0; j< count;j++)
            {
                for (int i = 0; i<count-1; i++)
                {
                    if (array[i]*s>array[i+1])
                    {
                        temp = array[i];
                        mess = s1[i];
                        array[i] = array[i+1];
                        s1[i] = s1[i+1];
                        array[i+1] = temp;
                        s1[i+1] = mess;
                    }
                }
            }
        }
        public string IndexOfValue (string item)
        {
           for (int i = 0; i<count; i++)
           {
                if(item==s1[i])
                {
                    return Convert.ToString(i);
                }
           }
           return Convert.ToString(-1);
        }
        public int IndexOfKey(int item)
        {
           // Array.Sort(data, 0, count);
            Sort(data);
            int left = 0;
            int right = count;
            int val = item;
            do
            {
                int middle = (left + right) / 2;
                if (val > data[middle])
                {
                    left = middle + 1;
                }
                else right = middle - 1;
                if (data[middle] == val)
                {
                    return middle;
                }
                //if (left > right) break;
            }
            while (left <= right);
            return -1;
        }
        public IEnumerator GetEnumerator()
        {
            SortedNode curr = head;
            for (int i = 0; i <count; i++)
            {
                string n = "[";
                n+= Convert.ToString(curr.key);
                n += ", ";
                n += curr.value;
                n += "]";
                yield return n;
                
                curr = curr.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int key1 (SortedNode a)
        {
            return a.key;
        }
        public int CompareTo(object obj)
        {
           throw new NotImplementedException();
           // return CompareTo(((DoubleNode)obj).key);
        }


        public int this[int key]
        {
            get
            {
                SortedNode current = head;
                for (int i = 0; i < key && current != null; i++)
                {
                    current = current.Next;
                }
                return current.key;
            }
            set
            {
                SortedNode current = head;
                current.key = value;
            }

        }
    }
}
