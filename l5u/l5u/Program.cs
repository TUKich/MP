using System;

namespace l5u
{
    public class Program
    {
        bool signs(double x, double y)
        {
            var sx = x < 0 ? -1 : 1;
            var sy = y < 0 ? -1 : 1;
            return sx == sy;
        }

        public bool CheckPoints(double x, double y, double r)
        {
            var r_xy = Math.Sqrt(x * x + y * y);
            if (r_xy <= r && (signs(x, y) || ((x <= 0 && y >= 0) && Math.Abs(x) + y <= r))) return true;
            return false;
        }
        
        
        
        static void Main(string[] args)
        {
            
        }
    }
}