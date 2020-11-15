using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Compare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка четности целого числа");
            Console.WriteLine();

            Console.WriteLine("Введите целое число и нажмите Enter");
            int Var = int.Parse(Console.ReadLine());

            if (Var % 2 == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Введенное число " + Var + " - чётное");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Введенное число " + Var + " - нечётное");
                Console.WriteLine();
            }

         
        }
    }
}
