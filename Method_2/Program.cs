using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MyArray = new int[10, 10];
            Random random = new Random();

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    MyArray[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    Console.Write(MyArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===========================");
            Console.WriteLine("Перед Вами случайно сгенерированный Массив, укажите число,");
            Console.Write("меньше которого вы хотите найти в указанной таблице: ");
            int EnteredNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            FindIndexArray(MyArray, EnteredNum);

        }

        static void FindIndexArray (int [,] CurArray, int Finder)
        {
            try
            {
                int[] NewArray = new int[2];
                int Count_1 = 0;
                int Count_2 = 0;

                for (; Count_1 < CurArray.GetLength(0); Count_1++)
                {
                    for (; Count_2 < CurArray.GetLength(1); Count_2++)
                    {
                        if (CurArray[Count_1, Count_2] < Finder)
                        {
                            NewArray[0] = Count_1;
                            NewArray[1] = Count_2;
                            break;
                        }
                    }
                    if (CurArray[Count_1, Count_2] < Finder)
                    {
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Индекс найденного значения Y: " + NewArray[0] + ", Х: " + NewArray[1]);
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Такого значения в указанной таблице, к сожалению, нет");
                Console.WriteLine();
            }
            
        }

        
    }
}
