using System;
using System.Collections;
using System.Collections.Generic;


namespace lab2u
{
    public class Program
    {
         Stack<int> st = new Stack<int>();
         int[] ints = new int[4];  
        public void add(int i1,int i2, int i3, int i4)
        {
            ints[0] = i1; 
            ints[1] = i2;
            ints[2] = i3;
            ints[3] = i4;
            foreach (int hh in ints)
            {
                st.Push(hh);
            }
        }
        public int peek()
        {
            return st.Peek();
        }

        public Boolean con( int i)
        {
            return st.Contains(i);
        }

        static void Main(string[] args)
        {
            
        }

        
    }
}