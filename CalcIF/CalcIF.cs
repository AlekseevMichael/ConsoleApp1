using System;

namespace CalcIF
{
    class CalcIF
    {
        static void Main(string[] args)
        {
            double Value1, Value2, Result;
            string Operator;

            Console.WriteLine("Простой калькулятор");
            Console.WriteLine();
            Console.WriteLine("Введите первое числовое значение и нажмите Enter");
            Value1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Какую операцию Вы хотите совершить? Введите соответствующий символ и нажмите Enter");
            Operator = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Введите второе числовое значение и нажмите Enter");
            Value2 = double.Parse(Console.ReadLine());

            if (Operator == "+")
            {
                Result = Value1 + Value2;
                Console.WriteLine();
                Console.WriteLine(Value1 + " + " + Value2 + " = " + Result);
                Console.WriteLine();
            }
            else
            {
                if (Operator == "-")
                {
                    Result = Value1 - Value2;
                    Console.WriteLine();
                    Console.WriteLine(Value1 + " - " + Value2 + " = " + Result);
                    Console.WriteLine();
                }
                else
                {
                    if (Operator == "*")
                    {
                        Result = Value1 * Value2;
                        Console.WriteLine();
                        Console.WriteLine(Value1 + " * " + Value2 + " = " + Result);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (Operator == "/")
                        {
                            if (Value2 != 0)
                            {
                                Result = Value1 / Value2;
                                Console.WriteLine();
                                Console.WriteLine(Value1 + " / " + Value2 + " = " + Result);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ошибка! Деление на ноль невозможно!");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ошибка! Вы ввели неверный символ операции!");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
