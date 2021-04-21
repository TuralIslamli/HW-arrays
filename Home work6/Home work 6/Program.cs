using System;

namespace Home_work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Сделать реверс массива (массив в обратном направлении).

            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];

            for (int i = 0; i < m.Length; i++)
            {

                Console.WriteLine($"Введите {i + 1} число");
                m[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");

            }
            Console.WriteLine($" Реверс вашего массива:");
            for (int i = m.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(m[i]);
            }
            Console.ReadKey();
        }
    }
}
