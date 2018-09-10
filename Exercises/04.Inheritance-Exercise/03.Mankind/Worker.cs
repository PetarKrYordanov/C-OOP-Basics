using System;

public class Worker : Human
{
    private const decimal minSalary = 10m;
    private const int workingDays = 5;

    private decimal salary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal salary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.Salary = salary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.salary = value;
        }
    }
    private decimal SalaryPerHour()
    {
        var salaryPerHour = this.salary / (decimal)(workHoursPerDay * workingDays);
        return Math.Round(salaryPerHour, 2);
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}{Environment.NewLine}" +
            $"Last Name: {this.LastName}{Environment.NewLine}" +
            $"Week Salary: {Math.Round(this.Salary, 2)}{Environment.NewLine}" +
            $"Hours per day: {this.WorkHoursPerDay}{Environment.NewLine}" +
            $"Salary per hour: {SalaryPerHour():f2}";
    }
}

