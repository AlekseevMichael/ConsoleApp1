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

        static void ChangeArrayElementSelector(int[] myArray)
        {
            bool exitLoop = false;
            while (exitLoop != true)
            {
                Console.WriteLine();
                Console.WriteLine("Вы желаете изменить какой-либо элемент массива?");
                Console.WriteLine("(Y) - Да, (N) - Нет, (Esc) - Выход");
                var input = Console.ReadKey().Key;
                int changerIndex = 0;

                switch (input)
                {
                    case ConsoleKey.Y:
                        {
                            ArrayChangeLocationSelector(ref changerIndex, myArray);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Введите значение для выбранного массива: ");
                            ModifyElementOfArray(changerIndex, myArray);
                            ShowArray(myArray);
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            exitLoop = true;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Введена неверная команда, повторите ввод");
                            break;
                        }
                }
            }
        }

        static void ArrayChangeLocationSelector(ref int changerIndex, int[] myArray)
        {
            bool exitLoop = false;
            while (exitLoop != true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("(F) - Изменить первый элемент массива, (E) - Изменить последний элемент массива, (I) - Изменить элемент массива по индексу");
                var input = Console.ReadKey().Key;

                switch(input)
                {
                    case ConsoleKey.F:
                        {
                            exitLoop = true;
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            changerIndex = myArray.Length - 1;
                            exitLoop = true;
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Введите индекс элемента массива, который хотите изменить: ");
                            changerIndex = int.Parse(Console.ReadLine());
                            exitLoop = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Введена неверная команда, повторите ввод");
                            break;
                        }
                }
            }
        }

        static void ModifyElementOfArray(int changerIndex, int[] myArray)
        {
            int resizer = int.Parse(Console.ReadLine());
            myArray[changerIndex] = resizer;
        }

        static void ShowArray(int[] myArray)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Ваш итоговый массив состоит из {myArray.Length} элементов и содержит следующие значения:");
            Console.WriteLine();
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"[{i}]\t{myArray[i]}");
            }
        }

        static void AddArrayElementSelector(int[] myArray)
        {
            bool exitLoop = false;
            while (exitLoop != true)
            {
                Console.WriteLine();
                Console.WriteLine("Вы желаете добавить или удалить элемент массива?");
                Console.WriteLine("(Y) - Да, (N) - Нет, (Esc) - Выход");
                var input = Console.ReadKey().Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        {
                            YAddArrayElement(myArray);

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Введите значение для выбранного массива: ");
                            //ModifyElementOfArray(changerIndex, myArray);
                            ShowArray(myArray);
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            exitLoop = true;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Введена неверная команда, повторите ввод");
                            break;
                        }
                }
            }
        }

        static void YAddArrayElement(int[] myArray)
        {
            bool exitLoop = false;
            while (exitLoop != true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("(I) - Добавить, (D) - Удалить");
                var input = Console.ReadKey().Key;
                int adderIndex = 0;
                bool _isAdd = false;

                switch (input)
                {
                    case ConsoleKey.I:
                        {
                            ArrayAddLocationSelector(ref adderIndex, myArray);

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Введите значение для данного элемента массива: ");
                            int newElementValue = int.Parse(Console.ReadLine());


                            //ModifyElementOfArray(changerIndex, myArray);
                            ShowArray(myArray);
                            exitLoop = true;
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            ArrayAddLocationSelector(ref adderIndex, myArray);


                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Введена неверная команда, повторите ввод");
                            break;
                        }
                }
            }
        }

        static void ArrayAddLocationSelector(ref int adderIndex, int[] myArray)
        {
            bool exitLoop = false;
            while (exitLoop != true)
            {
                Console.WriteLine();
                Console.WriteLine("(F) - В начало, (E) - В конец, (I) - По индексу");
                var input = Console.ReadKey().Key;

                switch (input)
                {
                    case ConsoleKey.F:
                        {
                            exitLoop = true;
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            adderIndex = myArray.Length;
                            exitLoop = true;
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Введите индекс элемента массива, который хотите изменить: ");
                            adderIndex = int.Parse(Console.ReadLine());
                            exitLoop = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Введена неверная команда, повторите ввод");
                            break;
                        }
                }
            }
        }

        static void CreateNewArray(int adderIndex, ref int[] myArray, ref int newElementValue)
        {
            int[] newArray;

        }

        static void Main(string[] args)
        {
                Console.Write("Введите желаемое количество элементов массива: ");
                uint arrayLenght = uint.Parse(Console.ReadLine());

                int[] myArray = new int[arrayLenght];
                Console.WriteLine();
                Console.WriteLine($"Ваш массив на {myArray.Length} элемента(ов) создан успешно");
                Console.WriteLine("Нажимте Enter для продолжения или Esc для выхода");

                //Изменение размера массива
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

                //Изменение элемента массива
                ChangeArrayElementSelector(myArray);

        }
    }
}
