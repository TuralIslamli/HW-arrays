using System;

namespace Home_work9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Отсортировать массив (пузырьком (Bubble) и почитать методы:  выбором (Select), вставками (Insert)) и попробовать отсортировать.

            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            
            for (int i = 0; i < m.Length; i++)
            {

                Console.WriteLine($"Введите {i + 1} число");
                m[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");

            }
            int sort;
            for (int i = 0; i < m.Length-1; i++)
            {
                for (int j = i+1; j < m.Length; j++)
                {
                    if (m[i]>m[j])
                    {
                        sort = m[i];
                        m[i] = m[j];
                        m[j] = sort;
                    }
                }
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
