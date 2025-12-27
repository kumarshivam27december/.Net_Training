using System;
class FullTimeEmployee : Employee
{
    public override double CalculateSalary(double hourlyRate,double hoursWorked)
    {
        return hourlyRate*hoursWorked;
    }
}