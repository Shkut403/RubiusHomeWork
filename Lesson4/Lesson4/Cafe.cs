namespace Lesson4
{
    using System;
    using System.Collections.Generic;

    public class Cafe
    {
        public string Name { get; set; }
        private List<Visitor> Visitors = new List<Visitor>();

        public Cafe(string name)
        {
            Name = name;
        }

        public void AddVisitor(Visitor visitor)
        {
            Visitors.Add(visitor);
            Console.WriteLine($"{visitor.Name} entered to {Name}.");
        }
    }
}
