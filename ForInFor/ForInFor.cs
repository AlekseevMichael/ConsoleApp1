using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForInFor
{
    class ForInFor
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольников: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                        Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = height; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= height; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j >= i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
