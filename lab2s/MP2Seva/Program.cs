using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MP2Seva
{
    public class Program
    {
        public Queue<long> numbers = new Queue<long>();
        public int MaxQueue;
         public Boolean Fill(long[] cot)
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