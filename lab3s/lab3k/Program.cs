using System;
using System.Collections;
using System.Collections.Generic;

namespace lab3k
{
    public class Program
    {
        public class DoublyLinkedList<T> : IEnumerable<T>  
    {
        Spisok<T> head; 
        Spisok<T> tail; 
        int count;  
 
        
        public void Add(T data)
        {
            Spisok<T> node = new Spisok<T>(data);
 
            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            Spisok<T> node = new Spisok<T>(data);
            Spisok<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        
        public bool Remove(T data)
        {
            Spisok<T> current = head;
 
            
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if(current!=null)
            {
                
                if(current.Next!=null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    
                    tail = current.Previous;
                }
 
                
                if(current.Previous!=null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
 
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
 
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
 
        public bool Contains(T data)
        {
            Spisok<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
         
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Spisok<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
 
        public IEnumerable<T> BackEnumerator()
        {
            Spisok<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
        public static void Main(String[] args){}
        
        public class Spisok<T>
        {
            public T Data { get; set; }
            public Spisok<T> Previous { get; set; }
            public Spisok<T> Next { get; set; }
        
            public Spisok(T data)
            {
                Data = data;
            }
        }

        public String Fill(String name)
        {
            DoublyLinkedList<long> s = new DoublyLinkedList<long>();
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
            DoublyLinkedList<long> s = new DoublyLinkedList<long>();
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

        public String back(String name)
        {
            DoublyLinkedList<long> s = new DoublyLinkedList<long>();
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

            String t = "";
            foreach (var y in s.BackEnumerator())
            {
                t =t + " " +y;
            }
            return t;
        }

        public Boolean con(String name, String search)
        {
            DoublyLinkedList<long> s = new DoublyLinkedList<long>();
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

    }
    

    
}