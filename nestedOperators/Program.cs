using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 10)
            {
                if (y < 8)
                {
                    Console.WriteLine(x + y); // выполнится только если x больше 10 и y меньше 8   
                }
            }

            Console.ReadKey();
        }
    }
}