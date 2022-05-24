using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int untreatedPatients = 0;
            int treatedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                int patientsPerDay = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors += 1;
                }
                if (patientsPerDay > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patientsPerDay - doctors;
                }
                else if (patientsPerDay <= doctors)
                {
                    treatedPatients += patientsPerDay;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
