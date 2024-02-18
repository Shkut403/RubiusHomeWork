namespace Lesson4
{
    public class Visitor
    {
        public string Name { get; set; }
        public Cafe Cafe { get; set; }

        public Visitor(string name, Cafe cafe)
        {
            Name = name;
            Cafe = cafe;
        }
    }
}
