using System;

namespace Home_work_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите имя первого пользователя:");
            string nameUser1 = Console.ReadLine();
            Console.WriteLine("Укажите возраст первого пользователя:");
            int ageUser1 = 0;
            for (int i = 0; ; i++)
            {
                string read1 = (Console.ReadLine());
                ageUser1 = 0;
                int.TryParse(read1, out ageUser1);
                if (ageUser1 <= 0)
                {
                    Console.WriteLine("Не правильный возраст, укажите правильную информацию.");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Укажите имя второго пользователя:");
            string nameUser2 = Console.ReadLine();
            Console.WriteLine("Укажите возраст второго пользователя:");
            int ageUser2 = 0;
            for (int i = 0; ; i++)
            {
                string read2 = (Console.ReadLine());
                ageUser2 = 0;
                int.TryParse(read2, out ageUser2);
                if (ageUser2 <= 0)
                {
                    Console.WriteLine("Не правильный возраст, укажите правильную информацию.");
                }
                else
                {
                    break;
                }
            }

            string result = " ";
            string peers = "'Они ровесники'";
            int ageRes = 0;
            string answer = Console.ReadLine();
            if (ageUser1 > ageUser2)
            {
                result = nameUser1;
                ageRes = ageUser1 - ageUser2;
            }
            else if (ageUser2 > ageUser1)
            {
                result = nameUser2;
                ageRes = ageUser2 - ageUser1;
            }

            Console.WriteLine($"Укажите имя пользователя который старше или {peers}, если они ровесники.");
            for (int i = 0; ; i++)
            {
                string msg = Console.ReadLine();
                if (msg == peers)
                {
                    Console.WriteLine("Да, они равесники.");
                    break;

                }

                else if (ageUser1 > ageUser2 && msg == nameUser2 || ageUser2 > ageUser1 && msg == nameUser1)
                {
                    Console.WriteLine($"Не правильный ответ. Пользователь {result} старше на {ageRes}.");
                    break;

                }
                else if (msg == result)
                {
                    Console.WriteLine($"Правильный ответ. Пользователь {result} старше на {ageRes}.");
                    break;
                }
                else if (msg != result)
                {
                    Console.WriteLine($"Такого пользователя нет, укажите точное имя.");
                    break;
                }
            }
            Console.ReadKey(); ;
        }
    }
}
