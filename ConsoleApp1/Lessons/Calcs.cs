using System;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример сложения и умножения трех вводимых чисел!!");
            Console.WriteLine();

            Console.WriteLine("Введите первое число и нажмите Enter");
            double FirstVal = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите второе число и нажмите Enter");
            double SecondVal = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите третье число и нажмите Enter");
            double ThirdVal = Double.Parse(Console.ReadLine());

            double sum = FirstVal + SecondVal + ThirdVal;
            double mult = FirstVal * SecondVal * ThirdVal;

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("Результатом сложения указанных чисел является: " + FirstVal + "+" + SecondVal + "+" + ThirdVal + "=" + sum);
            Console.WriteLine();
            Console.WriteLine("Результатом умножения указанных чисел является: " + FirstVal + "*" + SecondVal + "*" + ThirdVal + "=" + mult);
            Console.WriteLine();

        }
    }
}
