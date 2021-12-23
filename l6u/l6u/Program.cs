using System;

namespace l6u
{
    public class Program
    {
        public string Testik(string s)
        {
            char[] arrays = s.ToCharArray();
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = (char) (arrays[i] + 1);
            }

            string s1 = new string(arrays);
            return s1;
        }
        
        
        
        
        static void Main(string[] args)
        {

        }
    }
}