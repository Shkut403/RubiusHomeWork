namespace Lesson8__task_2_
{
    public class Pong
    {
        public event Action PongSent;
        private Random random = new Random();

        public void OnPingReceived()
        {
            if (random.Next(0, 10) < 8) // 80% шанс ответить понг
            {
                Console.WriteLine("Pong получил Ping");
                PongSent?.Invoke();
            }
            else
            {
                Console.WriteLine("Pong промахнулся! Победил Ping");
            }
        }
    }

}
