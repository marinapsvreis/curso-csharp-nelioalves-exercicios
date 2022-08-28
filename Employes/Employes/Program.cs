﻿using Employees.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Employes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)?");
                char option = char.Parse(Console.ReadLine());

                if(option == 'y' || option == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutsourcedEmployee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(employee);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
