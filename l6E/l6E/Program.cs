using System;
using System.Text;

namespace l6E
{
    public class Program
    {
        public string Put(string s, int i, string p)
        {
            String new_s = (new StringBuilder(s)).Insert(i, p).ToString();
            return new_s;
        }
        
        
        
        
        
        static void Main(string[] args)
        {
            
        }
    }
}