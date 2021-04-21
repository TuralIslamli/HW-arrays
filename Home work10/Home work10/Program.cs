using System;

namespace Home_work10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10. Заполнить массив из 20 элементов числами Фибоначчи и вывести егона экран (Fk = Fk-1 + Fk-2). Первые два числа - 0, 1


            int[] m = new int[20];
            m[0] = 0;
            m[1] = 1;
            for (int i = 2; i < m.Length; i++)
            {
                m[i] = m[i - 1] + m[i - 2];
            }
            foreach (int numElements in m)
            {
                Console.WriteLine(numElements);
            }
            Console.ReadKey();
        }
    }
}
