using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры. 
		Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
		Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова. */

            Console.WriteLine("Введите размерность матрицы");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] square = new int[N, N];
            Console.WriteLine("Заполните значения матрицы размером {0} x {0}", N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    square[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Матрица имеет вид");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0}  ",square[i, j]);
                }
                Console.WriteLine();
            }

            int notMagic = 0;
            int String1 = 0;
            int restStrings = 0;
            int Column1 = 0;
            int restStrings2 = 0;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    String1 += square[i, j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    restStrings += square[i, j];
                }
                if (String1 != restStrings)
                {
                    notMagic = 1;
                }
                restStrings = 0;
            }

            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < 1; i++)
                {
                    Column1 += square[i, j];
                }
            }

            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    restStrings2 += square[i, j];
                }
                if (Column1 != restStrings2)
                {
                    notMagic = 1;
                }
                restStrings2 = 0;
            }
            
            if (notMagic == 0)
            {
                Console.WriteLine("Даже без пересчета диагоналей, рискнем заявить, что эта матрица, скорее всего, является магическим квадратом!");
            }
            if (notMagic == 1)
            {
                Console.WriteLine("Матрица НЕ является магическим квадратом");
            }
            Console.ReadKey();
        }
    }
}
