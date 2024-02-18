namespace Lesson5
{
    using System;
    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }

        public Patient(string name, int age, string address, string status)
        {
            Name = name;
            Age = age;
            Address = address;
            Status = status;
        }
    }
}
