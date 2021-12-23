using System;

namespace l7u
{
    public class Program
    {
        public string threein12(string c)
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
                for (; temp1 / 12 >-1;temp1 = temp1 / 12)
                {
                    temp2 = temp1 % 12;
                    
                    if (temp2 == 10) {y = "A" + y; continue;}
                    if (temp2 == 11) {y = "B" + y; continue;}
                    if(temp1/12 ==  0 && temp1<15) break;
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
           
        }
    }
}