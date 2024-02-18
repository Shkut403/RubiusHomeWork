namespace Lesson3
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write array size:");
            int size = 0;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Incorrect. Please, write positive integer number.");
            }

            int[] array = new int[size];

            Console.WriteLine($"Write {size} integer numbers:");
            for (int i = 0; i < size; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Incorrect. Please, write integer number.");
                }
            }

            string result = FindSecondLargest(array);
            Console.WriteLine($"Second largest element in array: {result}");
        }
        // Описание метода "FindSecondLargest" приведено ниже
        static string FindSecondLargest(int[] array)
        {
            int? max = null;
            int? secondMax = null;

            foreach (int number in array)
            {
                if (!max.HasValue || number > max)
                {
                    secondMax = max;
                    max = number;
                }
                else if (number < max && (!secondMax.HasValue || number > secondMax))
                {
                    secondMax = number;
                }
            }

            // Возвращаем "Absent", если secondMax равно null
            return secondMax.HasValue ? secondMax.ToString() : "Absent";
        }
    }
}
