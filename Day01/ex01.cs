using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class ex01
    {
        public static int fatorialRecursivo(int n)
        {
            if (n == 0) return 1;
            else return n * fatorialRecursivo(n - 1);
        }
        static void Main(string[] args)
        {

            fatorialRecursivo(5);

            
            Console.ReadLine();
        }
    }
}
