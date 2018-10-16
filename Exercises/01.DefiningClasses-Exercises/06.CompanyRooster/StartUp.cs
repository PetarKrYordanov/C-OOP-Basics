using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var numberOfLines = int.Parse(Console.ReadLine());

        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < numberOfLines; i++)
        {
            var inputEmployeeArgs = Console.ReadLine().Split();
            AddEmployeeIntoList(inputEmployeeArgs, employees);
        }

      var  sortedByAverageSalary = employees.GroupBy(e => e.Department)
                                .Select(g => new { Department = g.Key, Avg = g.Average(e => e.Salary) }).OrderByDescending(g=>g.Avg);

        var firstDepartment = sortedByAverageSalary.First().Department;
        Console.WriteLine($"Highest Average Salary: {firstDepartment}");

        foreach (var empl in employees.Where(x=>x.Department ==firstDepartment).OrderByDescending(x=>x.Salary))
        {
            Console.WriteLine($"{empl.Name} {empl.Salary:f2} {empl.Email} {empl.Age}");
        }
    }

    private static void AddEmployeeIntoList(string[] inputEmployeeArgs, List<Employee> employees)
    {
        string name = inputEmployeeArgs[0];
        decimal salary = decimal.Parse(inputEmployeeArgs[1]);
        string position = inputEmployeeArgs[2];
        string department = inputEmployeeArgs[3];
        Employee currentEmployee = new Employee(name, salary, position, department);

        if (inputEmployeeArgs.Length==5)
        {
            if (inputEmployeeArgs[4].Contains("@"))
            {
                currentEmployee.Email = inputEmployeeArgs[4];
            }
            else
            {
                currentEmployee.Age = int.Parse(inputEmployeeArgs[4]);
            }
        }
        else if (inputEmployeeArgs.Length ==6)
        {
            currentEmployee.Email = inputEmployeeArgs[4];
            currentEmployee.Age = int.Parse(inputEmployeeArgs[5]);
        }
        employees.Add(currentEmployee);
    }
}

