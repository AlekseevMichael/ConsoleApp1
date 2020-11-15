using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Arithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double FirstVal = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double SecondVal = Double.Parse(Console.ReadLine());

            double result = (FirstVal + SecondVal) / 2;

            Console.WriteLine("Среднее арифметическое данных чисел равно = " + result);
        }
    }
}
