using System;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string str1 = Console.ReadLine();
            int a = Convert.ToInt32(str1);

            Console.WriteLine("Введите второе число");
            string str2 = Console.ReadLine();
            int b = Convert.ToInt32(str2);

            int result = (a + b) / 2;

            Console.WriteLine("Среднее арифметическое данных чисел равно: " + result);
         
            
        }
    }
}
