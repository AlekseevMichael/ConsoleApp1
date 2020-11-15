using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Array1
    {
        static void Main(string[] args)
        {
            int EvenSumm = 0;
            int SmallerNumber;

            Console.Write("Введите длину массива данных: ");
            uint ArrayLength = uint.Parse(Console.ReadLine());

            int[] MyArray = new int[ArrayLength];

            Console.WriteLine("Введите числа для массива данных:");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-------------------------------");
            Console.Write("Ваш массив данных состоит из: ");
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (i == MyArray.Length - 1)
                {
                    Console.WriteLine(MyArray[i] + ".");
                    break;
                }
                Console.Write(MyArray[i] + ", ");
            }

            Console.WriteLine("-------------------------------");
            Console.Write("Ваш массив в обратном порядке: ");
            for (int i = 1; i <= MyArray.Length; i++)
            {
                if (i == MyArray.Length)
                {
                    Console.WriteLine(MyArray[MyArray.Length - i] + ".");
                    break;
                }
                Console.Write(MyArray[MyArray.Length - i] + ", ");
            }

            Console.WriteLine("-------------------------------");
            Console.Write("Сумма четных чисел в Вашем массиве: ");
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 == 0)
                {
                    EvenSumm += MyArray[i];
                }
            }
            Console.WriteLine(EvenSumm + ".");

            Console.WriteLine("-------------------------------");
            Console.Write("Наименьшее в Вашем массиве: ");
            SmallerNumber = MyArray[0];
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] < SmallerNumber)
                {
                    SmallerNumber = MyArray[i];
                }
            }
            Console.WriteLine(SmallerNumber + ".");


            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
