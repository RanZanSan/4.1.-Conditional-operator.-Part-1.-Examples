using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorsIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("Положительное");
            }
            else
            {
                Console.WriteLine("Не положительное");
            }

            Console.ReadKey();
        }
    }
}