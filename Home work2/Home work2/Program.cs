using System;

namespace Home_work2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Найти максимальный элемент массива.


            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            int max = 0;
            for (int i = 0; i < m.Length; i++)
            {

                Console.WriteLine($"Введите {i + 1} число");
                m[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");


            }
            for (int j = 0; j < m.Length; j++)
            {

                if (max <= m[j])
                {
                    max = m[j];

                }
            }
            Console.WriteLine($"Максимальный элемент массива {max}");
            Console.ReadKey();
            ;
        }
    }
}
