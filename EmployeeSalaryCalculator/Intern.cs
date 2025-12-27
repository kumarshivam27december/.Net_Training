using System;
class Intern : Employee
{
    public override double CalculateSalary(double hourlyRate,double hoursWorked)
    {
        return hourlyRate*hoursWorked - 0.4*(hourlyRate*hoursWorked);
    }
}