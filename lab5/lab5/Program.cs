using System;


namespace lab5
{
    public class Program
    {
        public Boolean CheckPoints(double x, double y, double R)
        {
            try
            {
                if ((y >= 0 && x * x + y * y <= R * R) || (y <= x && y >= -R && x <= 0))
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        
        static void Main(string[] args)
        {
        }
        
    }
}