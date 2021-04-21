using System;

namespace Home_work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Посчитать сумму элементов массива с нечетными индексами.

            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            int summOddInd = 0;

            for (int i = 0; i < m.Length; i++)
            {

                Console.WriteLine($"Введите {i + 1} число");
                m[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");

                if (i % 2 != 0)
                {
                    summOddInd += m[i];
                }
            }
            Console.WriteLine($"Сумма элементов массива с нечетными индексами {summOddInd}");
            Console.ReadKey();
        }
    }
}
