using System;
using System.Text;

namespace lab6
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
            String s = "Привет ";
            String new_s = (new StringBuilder(s)).Insert(7, "Мир").ToString();
            Console.WriteLine(new_s);
        }
    }
}
