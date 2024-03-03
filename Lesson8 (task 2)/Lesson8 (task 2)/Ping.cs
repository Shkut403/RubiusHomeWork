namespace Lesson8__task_2_
{
    using System;

    public class Ping
    {
        public event Action PingSent;
        private Random random = new Random();

        public void SendPing()
        {
            if (random.Next(0, 10) < 8) // 80% шанс отправить пинг
            {
                Console.WriteLine("Ping получил Pong");
                PingSent?.Invoke();
            }
            else
            {
                Console.WriteLine("Ping промахнулся! Победил Pong");
            }
        }
    }

}
