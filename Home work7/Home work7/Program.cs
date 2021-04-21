using System;

namespace Home_work7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Посчитать количество нечетных элементов массива.

            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            int oddElements = 0;
            for (int i = 0; i < m.Length; i++)
            {

                Console.WriteLine($"Введите {i + 1} число");
                m[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");

                if (m[i]%2!=0)
                {
                    oddElements++;
                }
                
            }
            Console.WriteLine($"Количество нечетных элементов массива:{oddElements}.");
            Console.ReadKey();
        }
    }
}
