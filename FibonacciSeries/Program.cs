using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        public static int FibonacciSeries(int number)
        {
            int sum = 0;
            if (number <= 1) return 1;
            else
            {
                sum = (FibonacciSeries(number - 1) + FibonacciSeries(number - 2));
                return sum;
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the Term of the Fibonacci Series: ");
            int term = Convert.ToInt32(Console.ReadLine());
            int Result = FibonacciSeries(term);
            Console.Write("the term {0} of the fibonacci series is :  " + Result, term);
            Console.ReadKey();
        }
    }
}