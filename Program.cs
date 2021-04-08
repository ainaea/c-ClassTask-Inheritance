using System;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Employee[] allEmployees = { new Worker("Ade Olaade", 300, 35M), new JuniorManager("James Stuart", 12000, 200), new SeniorManager("Jane Wallace", 15000, 8)};

            foreach (Employee employee in allEmployees)
            {
                Console.WriteLine($"{employee.Name} will takehome {employee.GetSalary():C}");
            }
        }
    }
}
