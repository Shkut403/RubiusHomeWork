using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите год:");
        string input = Console.ReadLine();
        int year;

        bool success = int.TryParse(input, out year);
        if (success)
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
            Console.WriteLine("Введенное значение не является допустимым числом.");
        }
    }
        static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}