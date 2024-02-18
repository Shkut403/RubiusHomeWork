namespace Lesson6
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Создание и использование Stack<int>
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            Console.WriteLine($"Верхний элемент intStack: {intStack.Peek()}");
            Console.WriteLine($"Удален элемент из intStack: {intStack.Pop()}");
            Console.WriteLine($"Стек intStack пуст? {intStack.IsEmpty()}");

            // Создание и использование Stack<string>
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hello");
            stringStack.Push("World");
            Console.WriteLine($"Верхний элемент stringStack: {stringStack.Peek()}");
            stringStack.Clear();
            Console.WriteLine($"Стек stringStack пуст? {stringStack.IsEmpty()}");

            // Создание и использование Stack<double>
            Stack<double> doubleStack = new Stack<double>();
            doubleStack.Push(1.1);
            doubleStack.Push(2.2);
            Console.WriteLine($"Верхний элемент doubleStack: {doubleStack.Peek()}");
            Console.WriteLine($"Удален элемент из doubleStack: {doubleStack.Pop()}");
            Console.WriteLine($"Стек doubleStack пуст? {doubleStack.IsEmpty()}");
        }
    }
}