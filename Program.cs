﻿using System;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Employee[] allEmployees = { new Worker("Ade Olaade", 30, 12.5M), new JuniorManager("James Stuart", 12000, 3500, 200), new SeniorManager("Jane Wallace", 15000, 3000, 8)};

            foreach (Employee employee in allEmployees)
            {
                Console.WriteLine($"{employee.Name} will takehome {employee.GetSalary()}");
            }
        }
    }
}