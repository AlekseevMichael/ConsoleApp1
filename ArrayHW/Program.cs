using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW
{
    class Program
    {
        static void ResizeArray(ref int[] arr, int resizer)
        {
            int subArrayLenght = arr.Length + resizer;
            arr = new int[subArrayLenght];
        }

        static void RandomValueArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите желаемое количество элементов массива: ");
            uint arrayLenght = uint.Parse(Console.ReadLine());

            int[] myArray = new int[arrayLenght];
            Console.WriteLine();
            Console.WriteLine($"Ваш массив на {myArray.Length} элемента(ов) создан успешно");
            Console.WriteLine("Нажимте Enter для продолжения или Esc для выхода");

            var exitLoop = Console.ReadKey().Key;
            while (exitLoop != ConsoleKey.Escape)
            {
                Console.WriteLine();
                Console.WriteLine("Вы желаете увеличить или уменьшить количество элементов в массиве?");
                Console.WriteLine("(Y) - Да, (N) - Нет, ESC - выход");

                var input = Console.ReadKey().Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Увеличиваем или уменьшаем?");
                            Console.WriteLine("(U) - Увеличиваем, (D) - Уменьшаем");
                            var resizeInput = Console.ReadKey().Key;

                            switch (resizeInput)
                            {
                                case ConsoleKey.U:
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Увеличиваем на сколько элементов? ");
                                        int resizer = int.Parse(Console.ReadLine());
                                        ResizeArray(ref myArray, resizer);

                                        Console.WriteLine();
                                        Console.WriteLine($"Ваш массив теперь содержит {myArray.Length} элементов");
                                        Console.WriteLine();
                                        break;
                                    }
                                case ConsoleKey.D:
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Уменьшаем на сколько элементов? ");
                                        int resizer = -int.Parse(Console.ReadLine());
                                        try
                                        {
                                            ResizeArray(ref myArray, resizer);
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Количество элементов массива не может быть менее 0, убедитесь в правильности операции");
                                        }
                                        

                                        Console.WriteLine();
                                        Console.WriteLine($"Ваш массив теперь содержит {myArray.Length} элементов");
                                        Console.WriteLine();
                                        break;
                                    }
                                case ConsoleKey.Escape:
                                    {
                                        exitLoop = ConsoleKey.Escape;
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Осуществляется выход из программы");
                                        Console.WriteLine();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Неверно введено значение, повторите операцию");
                                        Console.WriteLine();
                                        break;
                                    }
                            }
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            exitLoop = ConsoleKey.Escape;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"Ваш итоговый массив состоит из {myArray.Length} элементов и содержит следующие значения:");
                            Console.WriteLine();
                            RandomValueArray(myArray);
                            for (int i = 0; i < myArray.Length; i++)
                            {
                                Console.WriteLine($"[{i}]\t{myArray[i]}");
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            exitLoop = ConsoleKey.Escape;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Осуществляется выход из программы");
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Неверно введено значение, повторите операцию");
                            Console.WriteLine();
                            break;
                        }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Дальше можно будет добавлять и убирать элементы массива в начало, конец и по индексу, но не сегодня))");
        }  
    }
}
