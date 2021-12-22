using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public delegate double Function(double x);
    class Program
    {
        
        
        static void Main(string[] args)
        {
            double f(double x) => x*x*x*x/(0.5*x*x+x+6);
            Console.WriteLine(SimpsonRule.Integrate(x=>x*x*x*x/(0.5*x*x+x+6),0.4,1.0));
            Console.WriteLine(SimpsonRule.Integrate(x=>x*x*x*x/(0.5*x*x+x+6),0.4,1.0,3));
            Console.WriteLine();
            Console.WriteLine(trio.LeftRectangle(x=>x*x*x*x/(0.5*x*x+x+6),0.4,1.0,3));
            Console.WriteLine(trio.CentralRectangle(x=>x*x*x*x/(0.5*x*x+x+6),0.4,1.0,3));
            Console.WriteLine(trio.RightRectangle(x=>x*x*x*x/(0.5*x*x+x+6),0.4,1.0,3));
            Console.WriteLine();
            Console.WriteLine(Trap.Trapi(0.4,1.0));
            
        }
        
    }
    public class SimpsonRule
    {
        /// <summary>
        /// Интегрирование методом Симпсона
        /// </summary>
        /// <param name="func">Функция. Запись в лямда выражении</param>
        /// <param name="a">Начало интервала</param>
        /// <param name="b">Конец интервала</param>
        /// <param name="n">Количество участков</param>
        /// <returns></returns>
        public static double Integrate(Func<double, double> func, double a, double b)
        {
            double sum = 0;
            double n = 10;
            while (Math.Abs((b - a) / n) > 0.01)
            {
                n++;
            }
            
            double h = (b - a) / n; 
            
            double x = a + h;
            while (x < b)
            {
                sum += 4 * func(x);
                x += h;
                sum += 2 * func(x);
                x += h;
            }
            sum = (h / 3) * (sum + func(a) - func(b));
 
            return sum;
        }
        /// <summary>
        /// Интегрирование методом Симпсона
        /// </summary>
        /// <param name="func">Функция. Запись в лямда выражении</param>
        /// <param name="a">Начало интервала</param>
        /// <param name="b">Конец интервала</param>
        /// <param name="n">Количество участков</param>
        /// <returns></returns>
        public static double Integrate(Func<double, double> func, double a, double b, int n)
        {
            double sum = 0;
            double h = (b - a) / n;
            double x = a + h;
 
            while (x < b)
            {
                sum += 4 * func(x);
                x += h;
                sum += 2 * func(x);
                x += h;
            }
            sum = (h / 3) * (sum + func(a) - func(b));
 
            return sum;
        }
    }

    public class trio
    {
        public static double LeftRectangle(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = 0d;
            for(var i = 0; i <= n-1; i++)
            {
                var x = a + i * h;
                sum += f(x);
            }

            var result = h * sum;
            return result;
        }

       public static double RightRectangle(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * h;
                sum += f(x);
            }

            var result = h * sum;
            return result;
        }

       public static double CentralRectangle(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = (f(a) + f(b)) / 2;
            for (var i = 1; i < n; i++)
            {
                var x = a + h * i;
                sum += f(x);
            }

            var result = h * sum;
            return result;
        }
    }

    public class Trap
    {
        static double f(double x) 
        {
            return x * x * x * x / (0.5 * x * x + x + 6);
        }

        public static double Trapi(double from, double to)
        {
            from = Math.Sqrt(from);
            to = Math.Sqrt(to);
            double Sum = 0, PreviousSum = 0; 
            double delta = 0.001; 
            double h = (to - from) / 2; 
            double oshibka;
            do
            {
                PreviousSum = Sum; 

                
                Sum = 0; 

                Sum = Sum + f(from); 
                Sum = Sum + f(to); 

                double x = from + h; 
                while (x < to) 
                {
                    Sum = Sum + 2 * f(x); 
                    x = x + h; 
                }

                Sum = Sum * h / 2;
                h = h / 2;
                oshibka = Math.Abs(Sum - PreviousSum) / Sum;
            } while (oshibka > delta);

            return Sum;
        }
    }
}