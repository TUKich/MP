using System;
using System.Linq.Expressions;

namespace l7E
{
    public class Program
    {
        public String ThreeTen(String c)
        {
            try
            {
                long u316 = Convert.ToInt64(c);
                for (int i = 0; i < c.Length; i++)
                {
                    if (u316 % 10 == 0 || u316 % 10 == 1 || u316 % 10 == 2)
                    {
                        continue;
                    }

                    throw new Exception();
                }

                string y = "";
                double temp = 0;
                double temp3 = 0;
                double temp2 = 0;
                for (double i = 0; i < c.Length; i++)
                {
                    temp3 = u316 % 10;
                    u316 = u316 / 10;
                    temp += (temp3) * Math.Pow(3, i);
                }

                long temp1 = Convert.ToInt64(temp);
                y += temp1;
                return y;
            }
            catch (Exception e)
            {
                return "null";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}