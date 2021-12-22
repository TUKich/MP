using System;

namespace l5k
{
    public class Program
    {
        public bool CheckPoints(double x, double y, double r)
        {
            if(x >= 0 && y >= 0 && (x-r)*(x-r)+y*y <= r*r)return true;
            if(x <= 0 && x >= -r && y<=0 && y >= -r && (x+r)*(x+r)+(y+r)*(y+r) >= r*r)return true;
            return false;
        }
        static void Main(string[] args)
        {
        }
    }
}