using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class ex02
    {
        public static int FibonacciRecursivo(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }
        static void Main(string[] args)
        {
            FibonacciRecursivo(10);

            Console.ReadLine();
        }
    }
}
