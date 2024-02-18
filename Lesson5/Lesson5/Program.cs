namespace Lesson5
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            Doctor therapist = new Doctor("Doctor Ivanov", "Therapist", 15);
            Doctor ophthalmologist = new Doctor("Doctor Smirnova", "Ophthalmologist", 20);
            Doctor neurologist = new Doctor("Doctor Petrov", "Neurologist", 25);

            Patient patient1 = new Patient("Alexey", 30, "Moscow", "Sick");
            Patient patient2 = new Patient("Maria", 25, "Saint Petersburg", "Healthy");

            therapist.Cure(patient1);
            ophthalmologist.Cure(patient2);
            neurologist.Cure(patient1);

            Console.WriteLine($"{patient1.Name} is now {patient1.Status}.");
            Console.WriteLine($"{patient2.Name} is now {patient2.Status}.");
            Console.WriteLine($"{neurologist.Name} ({neurologist.Specialization}) cured {patient1.Name}, he is {patient1.Status}.");
        }
    }
}