using System;

namespace Home_work8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите длину массива.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            int[] a= new int [n/2];
            int[] b = new int[n/2];
            int[] c = new int[1];
 

            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine($"Укажите число {i+1}");
                m[i] =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {i + 1} равно {m[i]}");

            }
            int d = 0;
            while (d == m.Length / 2 + 1)
            {
                c[0] = m[d];
            }





            if (n%2==0)
            {
                int k = 0;
                for (int j = 0; j < m.Length; j++)
                {
                    if (j < a.Length)
                    {
                        a[j] = m[j];
                    }
                    else
                    {
                        b[k] = m[j];
                        k++;
                    }
                }
                foreach (int pums in b) { Console.WriteLine(pums); }
                foreach (int nums in a) { Console.WriteLine(nums); }
            }
            else
            {
                int k = 0;
                for (int j = 0; j < m.Length-1; j++)
                {
                    if (j < a.Length)
                    {
                        a[j] = m[j];
                    }
                    else
                    {
                        b[k] = m[j+1];
                        c[k / 2] = m[j / 2 + 1];
                        k++;
                    }
                }
                foreach (int pums in b) { Console.WriteLine(pums); }
                foreach (int dums in c) { Console.WriteLine(dums); }
                foreach (int nums in a) { Console.WriteLine(nums); }
            }
            Console.ReadKey();
        }
    }
}
