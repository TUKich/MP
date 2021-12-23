﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace lu3
{
    
        public class LinkedList<T> : IEnumerable<T>  
    {
        Node<T> head; 
        Node<T> tail; 
        int count;  
 
        
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
 
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
 
            count++;
        }
        
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;
 
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    
                    if (previous != null)
                    {
                        
                        previous.Next = current.Next;
 
                        
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        
                        head = head.Next;
 
                        
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
 
                previous = current;
                current = current.Next;
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
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        
    }
        public class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }

        public class MyClass
        {
            static void Main(string[] args)
            {
            }
            public String Fill(String name)
        {
            LinkedList<float> s = new LinkedList<float>();
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
            LinkedList<float> s = new LinkedList<float>();
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
            LinkedList<float> s = new LinkedList<float>();
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
