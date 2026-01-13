using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    private const string FileName = "employees.json";

    static void Main()
    {
        List<Employee> employees = LoadEmployees();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee(employees);
                    SaveEmployees(employees);
                    break;

                case "2":
                    ViewEmployees(employees);
                    break;

                case "3":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    static void AddEmployee(List<Employee> employees)
    {
        Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Department: ");
        string department = Console.ReadLine();

        employees.Add(new Employee
        {
            Id = id,
            Name = name,
            Department = department
        });
    }

    static void ViewEmployees(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employee records found.");
            return;
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Department}");
        }
    }

    static void SaveEmployees(List<Employee> employees)
    {
        try
        {
            string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(FileName, json);
        }
        catch (Exception)
        {
            Console.WriteLine("Error saving employee data.");
        }
    }

    static List<Employee> LoadEmployees()
    {
        try
        {
            if (!File.Exists(FileName))
                return new List<Employee>();

            string json = File.ReadAllText(FileName);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Employee>();

            return JsonSerializer.Deserialize<List<Employee>>(json);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid employee data file. Starting with empty list.");
            return new List<Employee>();
        }
    }
}
