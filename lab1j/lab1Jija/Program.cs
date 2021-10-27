using System;

namespace ConsoleApp3
{
    public class Program
    {
        
        public  bool To(int R, int x, int y)
        {
            if(((x >= 0) &&(y >= 0) && (x * x + y * y <= R * R)) || ((x < 0) && (y < 0) && (y >= -x - R))) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            
        }
    }
}