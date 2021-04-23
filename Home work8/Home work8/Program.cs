using System;

namespace Home_work8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            int sort = 0;
            for (int i = 0; i < m.Length; i++)

            {

                Console.WriteLine($"Введите {i + 1} число");
                m[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");

            }

            int p = m.Length / 2 + m.Length % 2;

            for (int j = 0; j < m.Length / 2; j++)
            {
                sort = m[j];
                m[j] = m[p + j];
                m[p + j] = sort;
            }

            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
            Console.ReadKey();

        }
    }
}
