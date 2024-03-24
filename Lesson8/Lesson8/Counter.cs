namespace Lesson8
{
    public class Counter
    {
        public delegate void MethodContainer();
        public event MethodContainer OnCount;

        public void Count()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 77)
                {
                    OnCount?.Invoke();
                }
            }
        }
    }
}