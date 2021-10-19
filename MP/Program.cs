using System;

namespace MP
{
    public class Program
    {
       
       public int R1
        {
            get
            {
                return R2;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Must be greater or equal to zero");
                R2 = value;
            }
        }
       public int R2
        {
            get
            {
                return R2;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Must be greater or equal to zero");
                R2 = value;
            }
        }


        public Program(int R1,int R2)
        {
            this.R1 = R1;
            this.R2 = R2;
        }

        public Boolean Tochka(int x, int y)
        {
            if (((x ^ 2) + (y ^ 2) < R1) && ((x ^ 2) + (y ^ 2) > R2)) return true; else return false;
        }
        public static void Main(String[] args) { }
    }
}
