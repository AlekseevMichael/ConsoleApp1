using System;

namespace CalcSwitch
{
    class CalcSwitch
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double Value1, Value2, Result;
                string Operator;

                try
                {
                    Console.Clear();
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
                }
                catch (Exception)
                {
                    Console.WriteLine("Введенное значение не является числом! Повторите ввод.");
                    Console.ReadLine();
                    continue;
                }

                switch (Operator)
                {
                    case "+":
                        {
                            Result = Value1 + Value2;
                            Console.WriteLine();
                            Console.WriteLine(Value1 + " + " + Value2 + " = " + Result);
                            Console.WriteLine();
                            break;
                        }
                    case "-":
                        {
                            Result = Value1 - Value2;
                            Console.WriteLine();
                            Console.WriteLine(Value1 + " - " + Value2 + " = " + Result);
                            Console.WriteLine();
                            break;
                        }
                    case "*":
                        {
                            Result = Value1 * Value2;
                            Console.WriteLine();
                            Console.WriteLine(Value1 + " * " + Value2 + " = " + Result);
                            Console.WriteLine();
                            break;
                        }
                    case "/":
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
                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ошибка! Вы ввели неверный символ операции!");
                            Console.WriteLine();
                            break;
                        }
                }
                Console.ReadLine();
            }
        }
    }
}
