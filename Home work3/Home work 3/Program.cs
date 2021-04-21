using System;

namespace Home_work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Найти индекс минимального элемента массива.

            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            int min = 0;
            int minIndex = 0;


            for (int i = 0; i < m.Length; i++)
            {

                Console.WriteLine($"Введите {i + 1} число");
                m[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");
                min = m[i];

            }

            for (int j = 0; j < m.Length; j++)
            {

                if (min >= m[j])
                {
                    min = m[j];
                    minIndex = j;

                }

            }
            Console.WriteLine($"Индекс минимального элемента массива {minIndex}");
            Console.ReadLine();


        }
    }
}
