using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2Ed
{
    public class Program
    {
        public Queue<int> numbers = new Queue<int>();
        public int MaxQueue;
        public Boolean Fill(int[] cot)
        {
        if (cot.Length > 0)
        {
        for (int i = 0; i < cot.Length; i++)
        {
        numbers.Enqueue(cot[i]);
        }
        
        MaxQueue = cot.Length;
        return true;
        }
        else
        {
        return false;
        }
        
        }
        
        public long OutputHead()
        {
        return numbers.First();
        }
        
        public long OutputTail()
        {
        return numbers.Last();
        }
        
        public Boolean TestEmpty()
        {
        if (numbers.Any()) return false;
        else return true;
        }
        
        public Boolean TestFull()
        {
        if (numbers.Count == MaxQueue) return true;
        else return false;
        }
        
        public long Peek()
        {
        
        long a = numbers.Peek();
        return a;
        }
        
        static void Main(string[] args)
        {
        }
        }
        }
    
