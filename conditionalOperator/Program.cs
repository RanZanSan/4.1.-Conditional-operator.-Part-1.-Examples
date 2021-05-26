using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 10) // если больше 10
            {
                // внутри фигурных скобок пишутся инструкции(операторы), если условие верно(истинна)
                Console.WriteLine(x); // вывести х
            }

            Console.ReadKey();
        }
    }
}