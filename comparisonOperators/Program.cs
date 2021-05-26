using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 2;
            int c = 3;
            int d = 2;

            Console.WriteLine(b > c); // false
            Console.WriteLine(b < c); // true
            Console.WriteLine(b >= c); // false
            Console.WriteLine(b >= d); // true
            Console.WriteLine(b == c); // false
            Console.WriteLine(b == d); // true
            Console.WriteLine(b != c); // true
            Console.ReadKey();
        }
    }
}