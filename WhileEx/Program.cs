using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Счетчик четных и нечетных чисел в заданном диапазоне и их сумм
namespace WhileEx
{
    class Program
    {
        static void Main(string[] args)
        {
            uint EvenCount = 0; 
            uint OddCount = 0;
            int SumEven = 0;
            int SumOdd = 0;

            Console.WriteLine("Введите первое значение диапазона");
            int Value1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите второе значение диапазона");
            int Value2 = int.Parse(Console.ReadLine());

            while (Value1 <= Value2)
            {
                int ValueRes = Value1 % 2;
                if (ValueRes == 0)
                {
                    EvenCount++;
                    SumEven += Value1;
                }
                else
                {
                    OddCount++;
                    SumOdd += Value1;
                }
                ++Value1;
            }

            Console.WriteLine();
            Console.WriteLine("В указанном диапазоне " + EvenCount + " четных чисел и " + OddCount + " нечетных чисел");
            Console.WriteLine("Сумма четных чисел = " + SumEven + ", сумма нечетных чисел = " + SumOdd);
            Console.ReadLine();
        }
    }
}
