using System;

namespace l5E
{
    public class Program
    {

        public bool CheckPoints(double x, double y, double R)
        {
            if (x >= 0 && (x * x + y * y <= R * R) || (x <= 0 && y <= 0 && y <= x && y >= -R && x >= -R) ||
                (x <= 0 && y >= 0 && y >= -x && y <= R && x >= -R)) return true;
            return false;
        }
        
        
        
        static void Main(string[] args)
        {
            
        }
    }
}