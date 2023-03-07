using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int difference;
            double product;
            double quotient;

            total = mathOperation(5, 45);
            difference = mathOperation(100, 4, 68);
            product = mathOperation(3.78, 56.67);
            quotient = mathOperation(44.80, 5);

            Console.WriteLine(total);
            Console.WriteLine(difference); 
            Console.WriteLine(product); 
            Console.WriteLine(quotient);
            Console.ReadKey();
        }

        static int mathOperation(int a, int b) 
        { 
            return a + b;
        }
        static int mathOperation(int a, int b, int c)
        {
            return a - b - c;
        }
        static double mathOperation(double a, double b)
        {
            return a * b;
        }
        static double mathOperation(double a, int b)
        {
            return a / b;
        }
    }
}
