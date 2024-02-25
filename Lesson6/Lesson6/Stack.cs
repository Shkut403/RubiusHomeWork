namespace Lesson6
{
    using System;
    public class Stack<T>
    {
        private List<T> items = new List<T>();
        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стек пуст");
            }
            var item = items[^1];
            items.RemoveAt(items.Count - 1);
            return item;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стек пуст");
            }
            return items[^1];
        }
        public bool IsEmpty()
        {
            return items.Count == 0;
        }
        public void Clear()
        {
            items.Clear();
        }
    }
}