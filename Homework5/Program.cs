using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
            Console.WriteLine("Введите семь чисел");
            const int n = 7;
            double[] massive = new double[n];
            double Sum = 0;
            for (int i = 0; i < n; i++)
            {
                massive [i]  = Convert.ToDouble(Console.ReadLine());

               Sum += massive [i];

            }
            Double averageSum = Sum / n;
            Console.Write("Сумма всех введенных чисел равна {0}. Среднее арифметическое равно {1:f3}", Sum, averageSum);
            Console.ReadKey();
        }
    }
}
