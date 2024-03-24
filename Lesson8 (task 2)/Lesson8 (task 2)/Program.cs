using Lesson8__task_2_;
class Program
{
    static void Main(string[] args)
    {
        Ping ping = new Ping();
        Pong pong = new Pong();

        ping.PingSent += pong.OnPingReceived;
        pong.PongSent += ping.SendPing;

        ping.SendPing(); // Начинаем игру с пинга
    }
}
