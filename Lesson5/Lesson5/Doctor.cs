namespace Lesson5
{
    using System;
    class Doctor
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Experience { get; set; }

        public Doctor(string name, string specialization, int experience)
        {
            Name = name;
            Specialization = specialization;
            Experience = experience;
        }

        public void Cure(Patient patient)
        {
            Random random = new Random();
            patient.Status = random.Next(2) == 0 ? "Healthy" : "Sick";
            Console.WriteLine($"{Name} ({Specialization}) treated patient {patient.Name}.");
        }
    }

}
