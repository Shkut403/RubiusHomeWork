using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Другие методы посетителя
    }
}
