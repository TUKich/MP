using System;
using System.Numerics;

namespace lab7
{
     public class Program
    {
        public string threein16(string c)
        {
            
            try
            {
                
                
                long u316 = Convert.ToInt64(c);
                for (int i = 0; i < c.Length; i++)
                {
                    if (u316%10 == 0 || u316%10 == 1 || u316%10 == 2)
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
                    temp+=(temp3)*Math.Pow(3,i);
                }

                long temp1 = Convert.ToInt64(temp);
                for (; temp1 / 16 >-1;temp1 = temp1 / 16)
                {
                    temp2 = temp1 % 16;
                    
                    if (temp2 == 10) {y = "A" + y; continue;}
                    if (temp2 == 11) {y = "B" + y; continue;}
                    if (temp2 == 12) {y = "C" + y; continue;}
                    if (temp2 == 13) {y = "D" + y; continue;}
                    if (temp2 == 14) {y = "E" + y; continue;}
                    if (temp2 == 15) {y = "F" + y; continue;}
                    
                    
                    if(temp1/16 ==  0 && temp1<15) break;
                    y = temp2 + y;

                }

                return y;
            }
            catch (Exception e)
            {
                return "null";
                throw;
            }
            
        }
        
        
        
        static void Main(string[] args)
        {
            Program p = new Program();
            
            Console.WriteLine(p.threein16("210012000221220"));
        }
    }
}