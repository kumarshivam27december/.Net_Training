using System;
class Employee
{
    public virtual double CalculateSalary(double hourlyRate,double hoursWorked)
    {
        return hourlyRate*hoursWorked;
    }
}