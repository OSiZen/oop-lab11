using System;

namespace lab11
{
    class Program
    {
        //Task 1
        static void Substitute(string s, int p)
        {
            char[] str = s.ToCharArray();
            int n = s.Length;
            if ((p < 1) || (p > n))
            {
                Console.WriteLine("У рядку немає такої позицiї");
            }
            else
            {
                for (int i = p; i < n; i++)
                {
                    if (s[i] == '1')
                    {
                        str[i] = '0';
                    }
                    else if (s[i] == '0')
                    {
                        str[i] = '1';
                    }
                }
                Console.Write("Пiсля замiни: ");
                Console.WriteLine(str);
            }
        }

        //Task 2
        static void Counting(DateTime date)
        {
            Console.WriteLine($"Поточна дата {DateTime.Today.ToShortDateString()}");
            TimeSpan ts = date - DateTime.Today;
            if (ts.Days > 0)
            {
                Console.WriteLine($"Залишилося {ts.Days} днiв до заданої дати");
            }
            else if (ts.Days < 0)
            {
                Console.WriteLine($"Минуло {-ts.Days} днiв вiд заданої дати");
            }
            else
            {
                Console.WriteLine($"Цей день настав!");
            }
        }

        //Task 3
        static void Find(string str)
        {
            Console.WriteLine();
            DateTime dt1, dt2, dt3;
            string[] date = str.Split(new char[] { ',' });
            DateTime[] dt = new DateTime[3] { Convert.ToDateTime(date[0]), Convert.ToDateTime(date[1]), Convert.ToDateTime(date[2]) };
            Array.Sort(dt);
            if (dt[0].Day < dt[1].Day && dt[0].Day < dt[2].Day)
            {
                Console.WriteLine($"Дата з найменшим днем: {dt[0].ToShortDateString()}");
            }
            else if (dt[1].Day < dt[2].Day)
            {
                Console.WriteLine($"Дата з найменшим днем: {dt[1].ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"Дата з найменшим днем: {dt[2].ToShortDateString()}");
            }
            Console.WriteLine("\nВесняна дата:");
            for (int i = 0; i < dt.Length; i++)
            {
                if (dt[i].Month == 3 || dt[i].Month == 4 || dt[i].Month == 5)
                {
                    Console.Write($"{dt[i].ToShortDateString()}, ");
                }
            }
            Console.WriteLine("\n");
            if (dt[0] < dt[1] && dt[0] < dt[2])
            {
                Console.WriteLine($"Найпiзнiша дата: {dt[0].ToShortDateString()}");
            }
            else if (dt[1] < dt[2])
            {
                Console.WriteLine($"Найпiзнiша дата: {dt[1].ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"Найпiзнiша дата: {dt[2].ToShortDateString()}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введiть рядок: ");
            string str = Console.ReadLine();
            Console.Write("Введiть задану позицiю рядка: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Substitute(str, x);
            Console.WriteLine();
            Console.Write("Введiть день: ");
            int day = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введiть мiсяць: ");
            int month = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введiть рiк: ");
            int year = Convert.ToInt16(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            Counting(date);
            Console.WriteLine();
            Console.Write("Введiть 3 дати: ");
            string str2 = Console.ReadLine();
            Find(str2);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
