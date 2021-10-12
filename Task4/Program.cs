using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество нечетных положительных элементов, стоящих на четных местах.
            Console.WriteLine("Двадцать рандомных чисел в диапазоне [-50;50]: ");
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Элементы стоящие на нечетных местах:");

            int z = 0;

            for (int i = 0; i < n; i += 2)
            {
                int a = array[i];
                if (a > 0)
                {
                    int m = a / 2;

                    if (a != m + 0.5 * a)
                    {
                        z++;
                    }
                }
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();
            Console.Write("Количество нечетных положительных элементов равняется {0}.", z);
            Console.ReadKey();
        }
    }
}
