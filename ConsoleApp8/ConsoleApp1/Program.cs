using System;

namespace ConsoleApp1
{
    class Program
    {
        static double LeftLIST(Func<double, double> funk, int n)
        {
            double result = 0;
            double[] Mass = new double[n];
            for (int i = 0; i < n; i++)
            {
                Mass[i] = i + 1;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (i == 0)
                {
                    result = funk(Mass[0]);
                }
                else
                {
                    result = funk(Mass[i]);
                }
            }
            return result;
        }
        static double LeftLIST(Func<double, double, double> funk, int n)
        {
            double result = 0;
            double[] Mass = new double[n];
            for (int i = 0; i < n; i++)
            {
                Mass[i] = i + 1;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (i == 0)
                {
                    result = funk(Mass[0], Mass[1]);
                }
                else
                {
                    result = funk(result, Mass[i+1]);
                }
            }
            return result;
        }
        
        
        
        
        static void Main(string[] args)
        {
            Func<double, double> funk = (x) => x*x;
            Func<double, double, double> funk1 = (x, y) => (x + y)/2;
            Console.WriteLine(LeftLIST(funk,6));
            Console.WriteLine(LeftLIST(funk1,6));
        }
    }
}