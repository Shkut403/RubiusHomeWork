namespace Lesson2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите год (число должно быть больше 0 и меньше 30000):");
            string input = Console.ReadLine();
            int year;

            if (int.TryParse(input, out year) && year > 0 && year < 30000)
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение не является допустимым номером года (должно быть больше 0 и меньше 30000).");
            }
        }

        static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}