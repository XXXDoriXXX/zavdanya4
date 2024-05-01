using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
         static void Main(string[] args)
        {

            double a = 0, result = 0 ;
             a = double.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                result += 1.0 / Factorial(i);
            }
            Console.WriteLine("Результат: " + result);

        }
        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}


