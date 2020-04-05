using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1 zadanie
            Console.WriteLine("////1 zadanie////");
            MyLinkedList m1 = new MyLinkedList();
            m1.AddLast(1);
            m1.AddLast(2);
            m1.AddFirst(0);
            m1.AddFirst(0);
            m1.Insert(2, 1);
            Console.WriteLine(m1.Last());
            Console.WriteLine();
            m1.Remove(4);
            for (int i = 0; i < m1.count; i++)
            {
                Console.WriteLine(m1[i]);
            }

            Console.WriteLine();
            Console.WriteLine(m1.First());

            Console.WriteLine();
            //Console.WriteLine(m1.Size());
            //m1.Clear();
            //Console.WriteLine(m1.Size());
            Console.WriteLine(m1.IndexOf(1));

            //foreach (var i in m1)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine();


            /////////////////
            // 2 zadanie 
            Console.WriteLine("////2 zadanie/////");
            DoubleLinkedList m2 = new DoubleLinkedList();
            m2.AddLast(1);
            m2.AddLast(3);
            m2.AddLast(1);
            m2.AddLast(2);
            m2.AddFirst(-1);
            m2.Insert(2, 2);
           // m2.Remove(2);
            Console.WriteLine( m2.IndexOf(2));
            Console.WriteLine();
            //for (int i = 0; i< m2.count; i++)
            //{
            //    Console.WriteLine(m2[i]);
            //}

            foreach (var i in m2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();


            /////////////////
            // bonus 
            Console.WriteLine("////bonus/////");
            MySortedList m3 = new MySortedList();
            m3.Add(1, "d");
            m3.Add(3, "b");
            m3.Add(2, "a");
            m3.Add(5, "c");
            foreach (var i in m3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(m3.IndexOfKey(2));
            Console.WriteLine(m3.IndexOfKey(10));
            Console.WriteLine(m3.IndexOfValue("b"));
            Console.WriteLine(m3.IndexOfValue("g"));


        }
    }
}
