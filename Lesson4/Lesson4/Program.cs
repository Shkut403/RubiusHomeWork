namespace Lesson4

{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Cafe myCafe = new Cafe("Lovely cafe");
            Visitor visitor1 = new Visitor("Jack", myCafe);
            Visitor visitor2 = new Visitor("Jill", myCafe);

            myCafe.AddVisitor(visitor1);
            myCafe.AddVisitor(visitor2);

            // Связь коллекций Cafe и Visitor
        }
    }
}