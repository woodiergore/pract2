using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    internal class Matritza
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число строк n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число столбцов m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int plus = 0;
            double a;

            Console.Write("Матрица размерности:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    a = Math.Round(Math.Sin(i + j / 2), 2);
                    if (a > 0) plus++;
                    Console.Write(a + "\t");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Число положительных элементов матрицы равно {plus}");
            Console.ReadKey();
        }
    }
}
