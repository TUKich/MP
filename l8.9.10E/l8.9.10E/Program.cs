using System;

namespace l8._9._10E
{
    using System.Collections;
    using System.Collections.Generic;

    namespace SimpleAlgorithmsApp
    {
        public class CircularDoublyLinkedList<T> : IEnumerable<T> 
        {
            DoublyNode<T> head;
            int count;


            public void Add(T data)
            {
                DoublyNode<T> node = new DoublyNode<T>(data);

                if (head == null)
                {
                    head = node;
                    head.Next = node;
                    head.Previous = node;
                }
                else
                {
                    node.Previous = head.Previous;
                    node.Next = head;
                    head.Previous.Next = node;
                    head.Previous = node;
                }

                count++;
            }

            public bool Remove(T data)
            {
                DoublyNode<T> current = head;

                DoublyNode<T> removedItem = null;
                if (count == 0) return false;


                do
                {
                    if (current.Data.Equals(data))
                    {
                        removedItem = current;
                        break;
                    }

                    current = current.Next;
                } while (current != head);

                if (removedItem != null)
                {

                    if (count == 1)
                        head = null;
                    else
                    {

                        if (removedItem == head)
                        {
                            head = head.Next;
                        }

                        removedItem.Previous.Next = removedItem.Next;
                        removedItem.Next.Previous = removedItem.Previous;
                    }

                    count--;
                    return true;
                }

                return false;
            }

            public int Count
            {
                get { return count; }
            }

            public bool IsEmpty
            {
                get { return count == 0; }
            }

            public void Clear()
            {
                head = null;
                count = 0;
            }

            public bool Contains(T data)
            {
                DoublyNode<T> current = head;
                if (current == null) return false;
                do
                {
                    if (current.Data.Equals(data))
                        return true;
                    current = current.Next;
                } while (current != head);

                return false;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable) this).GetEnumerator();
            }

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                DoublyNode<T> current = head;
                do
                {
                    if (current != null)
                    {
                        yield return current.Data;
                        current = current.Next;
                    }
                } while (current != head);
            }
        }

        public class DoublyNode<T>
        {
            public DoublyNode(T data)
            {
                Data = data;
            }

            public T Data { get; set; }
            public DoublyNode<T> Previous { get; set; }
            public DoublyNode<T> Next { get; set; }
        }



        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
             public String Fill(String name)
        {
            CircularDoublyLinkedList<long> s = new CircularDoublyLinkedList<long>();
            String[] names = name.Split(' ');
            String t = null;
            long[] l = new long[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                l[i] = long.Parse(names[i]);
            }
            
            for (int i = 0; i < names.Length; i++)
            {
                s.Add(l[i]);
            }

            t = "";
            foreach (var y in s)
            {
                t =t + " " +y;
            }
            return t;
        }

        public String remove(String name, String remove)
        {
            CircularDoublyLinkedList<long> s = new CircularDoublyLinkedList<long>();
            String[] names = name.Split(' ');
            String t = null;
            long[] l = new long[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                l[i] = long.Parse(names[i]);
            }
            
            for (int i = 0; i < names.Length; i++)
            {
                s.Add(l[i]);
            }

            long re = long.Parse(remove);
            s.Remove(re);
            t = "";
            foreach (var y in s)
            {
                t =t + " " +y;
            }
            return t;
        }

        

        public Boolean con(String name, String search)
        {
            CircularDoublyLinkedList<long> s = new CircularDoublyLinkedList<long>();
            String[] names = name.Split(' ');
            long[] l = new long[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                l[i] = long.Parse(names[i]);
            }
            
            for (int i = 0; i < names.Length; i++)
            {
                s.Add(l[i]);
            }

            long se = long.Parse(search);
            return s.Contains(se);
        }

        public long AVG(String name)
        {
            CircularDoublyLinkedList<long> s = new CircularDoublyLinkedList<long>();
            String[] names = name.Split(' ');
            long[] l = new long[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                l[i] = long.Parse(names[i]);
            }
            
            for (int i = 0; i < names.Length; i++)
            {
                s.Add(l[i]);
            }
            var t = "";
            long u = 1;
            foreach (var y in s)
            {
                u *= y;
            }

            return (long) Math.Sqrt(u);

        }
        }
    }
}
