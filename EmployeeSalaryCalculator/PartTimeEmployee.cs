using System;
class PartTimeEmployee : Employee
{
    public override double CalculateSalary(double hourlyRate,double hoursWorked)
    {
        return hourlyRate*hoursWorked - 0.2*(hourlyRate*hoursWorked);
    }
}